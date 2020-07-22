using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    /// <inheritdoc />
    public partial class WarcraftClient : IWarcraftClient
    {
        private static readonly JsonSerializerOptions s_jsonSerializerOptions;

        private readonly HttpClient _client;
        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly Region _region;
        private readonly Locale _locale;

        private OAuthAccessToken _token;
        private DateTimeOffset _tokenExpiration;

        /// <summary>
        /// A static constructor for the <see cref="WarcraftClient"/> class.
        /// </summary>
        static WarcraftClient()
        {
            s_jsonSerializerOptions = new JsonSerializerOptions();
            s_jsonSerializerOptions.Converters.Add(new EpochConverter());
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="WarcraftClient"/> class.
        /// </summary>
        /// <param name="clientId">The Blizzard OAuth client ID.</param>
        /// <param name="clientSecret">The Blizzard OAuth client secret.</param>
        /// <remarks>
        ///     Defaults the region to US and the locale to "en_US".
        /// </remarks>
        public WarcraftClient(string clientId, string clientSecret) : this(clientId, clientSecret, Region.US, Locale.en_US)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="WarcraftClient"/> class.
        /// </summary>
        /// <param name="clientId">The Blizzard OAuth client ID.</param>
        /// <param name="clientSecret">The Blizzard OAuth client secret.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">
        ///     Specifies the language that the result will be in. Visit
        ///     https://develop.battle.net/documentation/world-of-warcraft/guides/localization to see a list of available locales.
        /// </param>
        public WarcraftClient(string clientId, string clientSecret, Region region, Locale locale) : this(clientId, clientSecret, region, locale, InternalHttpClient.Instance)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="WarcraftClient"/> class.
        /// </summary>
        /// <param name="clientId">The Blizzard OAuth client ID.</param>
        /// <param name="clientSecret">The Blizzard OAuth client secret.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">
        ///     Specifies the language that the result will be in. Visit
        ///     https://develop.battle.net/documentation/world-of-warcraft/guides/localization to see a list of available locales.
        /// </param>
        /// <param name="client">The <see cref="HttpClient"/> that communicates with Blizzard.</param>
        public WarcraftClient(string clientId, string clientSecret, Region region, Locale locale, HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
            _clientId = clientId ?? throw new ArgumentNullException(nameof(clientId));
            _clientSecret = clientSecret ?? throw new ArgumentNullException(nameof(clientSecret));

            if (!locale.IsSupportedInRegion(region))
            {
                throw new ArgumentException("The locale selected is not supported by the selected region.");
            }

            _region = region;
            _locale = locale;
        }

        /// <summary>
        /// The Blizzard OAuth client ID.
        /// </summary>
        internal string ClientId => _clientId;

        /// <summary>
        /// The Blizzard OAuth client secret.
        /// </summary>
        internal string ClientSecret => _clientSecret;

        /// <summary>
        /// The language that results will be in.
        /// </summary>
        internal Locale Locale => _locale;

        /// <summary>
        /// The region the API will retrieve data from.
        /// </summary>
        internal Region Region => _region;

        /// <summary>
        /// The <see cref="HttpClient"/> instance handling requests.
        /// </summary>
        internal HttpClient Client => _client;

        /// <summary>
        ///     Retrieve an item of type <typeparamref name="T"/> from the Blizzard World of Warcraft Game Data or Profile API.
        /// </summary>
        /// <typeparam name="T">
        ///     The return type.
        /// </typeparam>
        /// <param name="region">The region from which to request a token.</param>
        /// <param name="requestUri">
        ///     The URI the request is sent to.
        /// </param>
        /// <returns>
        ///     The JSON response, deserialized to an object of type <typeparamref name="T"/>.
        /// </returns>
        private async Task<RequestResult<T>> Get<T>(Region region, string requestUri)
        {
            // Acquire a new OAuth token if we don't have one. Get a new one if it's expired.
            if (_token == null || DateTimeOffset.UtcNow >= _tokenExpiration)
            {
                _token = await GetOAuthToken(region).ConfigureAwait(false);
                _tokenExpiration = DateTimeOffset.UtcNow.AddSeconds(_token.ExpiresIn).AddSeconds(-30);
            }

            return await Get<T>(region, requestUri, _token.AccessToken);
        }

        /// <summary>
        ///     Retrieve an item of type <typeparamref name="T"/> from the Blizzard World of Warcraft Game Data or Profile API.
        /// </summary>
        /// <typeparam name="T">
        ///     The return type.
        /// </typeparam>
        /// <param name="region">The region from which to request a token.</param>
        /// <param name="requestUri">
        ///     The URI the request is sent to.
        /// </param>
        /// <param name="accessToken">
        ///     The OAuth access token.
        /// </param>
        /// <returns>
        ///     The JSON response, deserialized to an object of type <typeparamref name="T"/>.
        /// </returns>
        private async Task<RequestResult<T>> Get<T>(Region region, string requestUri, string accessToken)
        {
            // Add an authentication header with the token.
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

            // Retrieve the response.
            HttpResponseMessage response = await _client.GetAsync(requestUri).ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
            {
                // Check if the request was successful and made it to the Blizzard API.
                // The API will always send back content if successful.
                if (response.Content != null)
                {
                    string content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                    if (!string.IsNullOrEmpty(content))
                    {
                        RequestResult<T> requestError = JsonSerializer.Deserialize<RequestError>(content);
                        return requestError;
                    }
                }

                // If not then it is most likely a problem on our end due to an HTTP error.
                string message = $"Response code {(int)response.StatusCode} ({response.ReasonPhrase}) does not indicate success. Request: {requestUri}";

                throw new HttpRequestException(message);
            }

            // Deserialize an object of type T from the JSON string.
            string json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            try
            {
                RequestResult<T> requestResult = JsonSerializer.Deserialize<T>(json, s_jsonSerializerOptions);
                return requestResult;
            }
            catch (JsonException ex)
            {
                var requestError = new RequestError
                {
                    Code = null,
                    Detail = ex.Message,
                    Type = typeof(JsonException).ToString()
                };
                return new RequestResult<T>(requestError);
            }
        }

        /// <summary>
        ///     Get an OAuth token.
        /// </summary>
        /// <param name="region">The region from which to request a token.</param>
        /// <returns>
        ///     An OAuth token.
        /// </returns>
        private async Task<OAuthAccessToken> GetOAuthToken(Region region)
        {
            string credentials = $"{_clientId}:{_clientSecret}";
            string host = GetOAuthHost(region);

            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes(credentials)));

            var requestBody = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "client_credentials")
            });

            HttpResponseMessage request = await _client.PostAsync($"{host}/oauth/token", requestBody);
            string response = await request.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<OAuthAccessToken>(response);
        }

        /// <summary>
        ///     Get the host for the specified region.
        /// </summary>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <returns>
        ///     The host for the specified region.
        /// </returns>
        private static string GetHost(Region region)
        {
            switch (region)
            {
                case Region.China:
                    return "https://gateway.battlenet.com.cn";
                case Region.Europe:
                    return "https://eu.api.blizzard.com";
                case Region.Korea:
                    return "https://kr.api.blizzard.com";
                case Region.Taiwan:
                    return "https://tw.api.blizzard.com";
                case Region.US:
                default:
                    return "https://us.api.blizzard.com";
            }
        }

        /// <summary>
        ///     Get the OAuth host for the specified region.
        /// </summary>
        /// <param name="region">Specifies the region for which an OAuth token will be acquired.</param>
        /// <returns>
        ///     The OAuth host for the specified region.
        /// </returns>
        private static string GetOAuthHost(Region region)
        {
            switch (region)
            {
                case Region.China:
                    return "https://www.battlenet.com.cn";
                case Region.Europe:
                    return "https://eu.battle.net";
                case Region.Korea:
                    return "https://kr.battle.net";
                case Region.Taiwan:
                    return "https://tw.battle.net";
                case Region.US:
                default:
                    return "https://us.battle.net";
            }
        }
    }
}
