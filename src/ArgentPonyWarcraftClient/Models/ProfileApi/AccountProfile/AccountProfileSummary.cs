namespace ArgentPonyWarcraftClient;

/// <summary>
/// A profile summary for an account.
/// </summary>
public record AccountProfileSummary
{
    /// <summary>
    /// Gets links for the profile summary for the account.
    /// </summary>
    [JsonPropertyName("_links")]
    public LinksForAccountProfile Links { get; init; }

    /// <summary>
    /// Gets the ID of the profile summary for the account.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the World of Warcraft accounts associated with the account profile.
    /// </summary>
    [JsonPropertyName("wow_accounts")]
    public WowAccount[] WowAccounts { get; init; }

    /// <summary>
    /// Gets a link to the collections for the account.
    /// </summary>
    [JsonPropertyName("collections")]
    public Self Collections { get; init; }
}
