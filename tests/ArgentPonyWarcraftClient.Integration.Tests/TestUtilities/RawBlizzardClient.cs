using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace ArgentPonyWarcraftClient.Integration.Tests;

/// <summary>
/// A wrapper around an <see cref="HttpClient"/> for getting the
/// raw HTTP responses from Blizzard's APIs.
/// </summary>
internal class RawBlizzardClient
{
    private static readonly HttpClient _client;

    private readonly ClientCredentials _credentials;

    private OAuthAccessToken _token;
    private DateTimeOffset _tokenExpiration;

    static RawBlizzardClient()
    {
        _client = new HttpClient();
        _client.Timeout = TimeSpan.FromMinutes(5);
    }

    public RawBlizzardClient(ClientCredentials credentials)
    {
        _credentials = credentials;
    }

    public async Task<string> GetRawBlizzardResponseAsync(string requestUri)
    {
        // Acquire a new OAuth token if we don't have one. Get a new one if it's expired.
        if (_token == null || DateTimeOffset.UtcNow >= _tokenExpiration)
        {
            Region region = GetRegionFromUri(requestUri);
            _token = await GetOAuthTokenAsync(region).ConfigureAwait(false);
            _tokenExpiration = DateTimeOffset.UtcNow.AddSeconds(_token.ExpiresIn).AddSeconds(-30);
        }

        return await GetRawBlizzardResponseAsync(requestUri, _token.AccessToken).ConfigureAwait(false);
    }

    private async Task<string> GetRawBlizzardResponseAsync(string requestUri, string accessToken)
    {
        // Add an authentication header with the token.
        _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

        // Retrieve the response.
        HttpResponseMessage response = await _client.GetAsync(requestUri).ConfigureAwait(false);

        return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
    }

    private async Task<OAuthAccessToken> GetOAuthTokenAsync(Region region)
    {
        string credentials = $"{_credentials.ClientId}:{_credentials.ClientSecret}";
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

    private static string GetOAuthHost(Region region)
    {
        return region switch
        {
            Region.China => "https://www.battlenet.com.cn",
            Region.Europe => "https://eu.battle.net",
            Region.Korea => "https://kr.battle.net",
            Region.Taiwan => "https://tw.battle.net",
            _ => "https://us.battle.net",
        };
    }
}
