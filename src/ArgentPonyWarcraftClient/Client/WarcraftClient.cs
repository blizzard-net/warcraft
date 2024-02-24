using System.Net.Http.Headers;
using System.Text;

namespace ArgentPonyWarcraftClient;

/// <inheritdoc />
public partial class WarcraftClient : IWarcraftClient
{
    private static readonly JsonSerializerOptions s_jsonSerializerOptions;
    private OAuthAccessToken _token;
    private DateTimeOffset _tokenExpiration;

    /// <summary>
    /// A static constructor for the <see cref="WarcraftClient"/> class.
    /// </summary>
    static WarcraftClient()
    {
        s_jsonSerializerOptions = new JsonSerializerOptions();
        s_jsonSerializerOptions.Converters.Add(new EpochConverter());
        s_jsonSerializerOptions.Converters.Add(new MillisecondTimeSpanConverter());
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
        Client = client ?? throw new ArgumentNullException(nameof(client));
        ClientId = clientId ?? throw new ArgumentNullException(nameof(clientId));
        ClientSecret = clientSecret ?? throw new ArgumentNullException(nameof(clientSecret));

        if (!locale.IsSupportedInRegion(region))
        {
            throw new ArgumentException("The locale selected is not supported by the selected region.");
        }

        Region = region;
        Locale = locale;
    }

    /// <summary>
    /// The Blizzard OAuth client ID.
    /// </summary>
    internal string ClientId { get; }

    /// <summary>
    /// The Blizzard OAuth client secret.
    /// </summary>
    internal string ClientSecret { get; }

    /// <summary>
    /// The language that results will be in.
    /// </summary>
    internal Locale Locale { get; }

    /// <summary>
    /// The region the API will retrieve data from.
    /// </summary>
    internal Region Region { get; }

    /// <summary>
    /// The <see cref="HttpClient"/> instance handling requests.
    /// </summary>
    internal HttpClient Client { get; }

    /// <summary>
    ///     Retrieve an item of type <typeparamref name="T"/> from the Blizzard World of Warcraft Game Data or Profile API.
    /// </summary>
    /// <typeparam name="T">
    ///     The return type.
    /// </typeparam>
    /// <param name="requestUri">
    ///     The URI the request is sent to.
    /// </param>
    /// <returns>
    ///     The JSON response, deserialized to an object of type <typeparamref name="T"/>.
    /// </returns>
    private async Task<RequestResult<T>> GetAsync<T>(string requestUri)
    {
        // Acquire a new OAuth token if we don't have one. Get a new one if it's expired.
        if (_token == null || DateTimeOffset.UtcNow >= _tokenExpiration)
        {
            Region region = GetRegionFromUri(requestUri);
            _token = await GetOAuthTokenAsync(region).ConfigureAwait(false);
            _tokenExpiration = DateTimeOffset.UtcNow.AddSeconds(_token.ExpiresIn).AddSeconds(-30);
        }

        return await GetAsync<T>(requestUri, _token.AccessToken).ConfigureAwait(false);
    }

    /// <summary>
    ///     Retrieve an item of type <typeparamref name="T"/> from the Blizzard World of Warcraft Game Data or Profile API.
    /// </summary>
    /// <typeparam name="T">
    ///     The return type.
    /// </typeparam>
    /// <param name="requestUri">
    ///     The URI the request is sent to.
    /// </param>
    /// <param name="accessToken">
    ///     The OAuth access token.
    /// </param>
    /// <returns>
    ///     The JSON response, deserialized to an object of type <typeparamref name="T"/>.
    /// </returns>
    private async Task<RequestResult<T>> GetAsync<T>(string requestUri, string accessToken)
    {
        // Add an authentication header with the token.
        Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

        // Retrieve the response.
        HttpResponseMessage response = await Client.GetAsync(requestUri).ConfigureAwait(false);

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
    private async Task<OAuthAccessToken> GetOAuthTokenAsync(Region region)
    {
        string credentials = $"{ClientId}:{ClientSecret}";
        string host = GetOAuthHost(region);

        Client.DefaultRequestHeaders.Accept.Clear();
        Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes(credentials)));

        var requestBody = new FormUrlEncodedContent(new[]
        {
                new KeyValuePair<string, string>("grant_type", "client_credentials")
            });

        HttpResponseMessage responseMessage = await Client.PostAsync($"{host}/oauth/token", requestBody);
        responseMessage.EnsureSuccessStatusCode();
        string response = await responseMessage.Content.ReadAsStringAsync();
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
        return region switch
        {
            Region.China => "https://gateway.battlenet.com.cn",
            Region.Europe => "https://eu.api.blizzard.com",
            Region.Korea => "https://kr.api.blizzard.com",
            Region.Taiwan => "https://tw.api.blizzard.com",
            _ => "https://us.api.blizzard.com",
        };
    }

    /// <summary>
    ///     Determine the region for a URI.
    /// </summary>
    /// <param name="requestUri">
    ///     The URI the request is sent to.
    /// </param>
    /// <returns>
    ///     The region corresponding to the URI.
    /// </returns>
    private static Region GetRegionFromUri(string requestUri)
    {
        Uri uri = new(requestUri);

        return uri.Host switch
        {
            "gateway.battlenet.com.cn" => Region.China,
            "eu.api.blizzard.com" => Region.Europe,
            "kr.api.blizzard.com" => Region.Korea,
            "tw.api.blizzard.com" => Region.Taiwan,
            "us.api.blizzard.com" => Region.US,
            _ => throw new ArgumentException($"The requestUri '{requestUri}' contains host '{uri.Host}', which is not recognized.", nameof(requestUri)),
        };
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
        return region switch
        {
            Region.China => "https://www.battlenet.com.cn",
            Region.Europe => "https://eu.battle.net",
            Region.Korea => "https://kr.battle.net",
            Region.Taiwan => "https://apac.battle.net",
            _ => "https://us.battle.net",
        };
    }
}
