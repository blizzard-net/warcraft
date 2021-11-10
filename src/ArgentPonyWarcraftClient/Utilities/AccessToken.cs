namespace ArgentPonyWarcraftClient;

/// <summary>
/// An OAuth access token for the Blizzard API.
/// </summary>
internal record OAuthAccessToken
{
    [JsonPropertyName("access_token")]
    public string AccessToken { get; init; }

    [JsonPropertyName("token_type")]
    public string TokenType { get; init; }

    [JsonPropertyName("expires_in")]
    public long ExpiresIn { get; init; }

    [JsonPropertyName("scope")]
    public string Scope { get; init; }
}
