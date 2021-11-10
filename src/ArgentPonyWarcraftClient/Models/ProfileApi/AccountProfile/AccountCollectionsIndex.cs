namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of collection types for an account.
/// </summary>
public record AccountCollectionsIndex
{
    /// <summary>
    /// Gets links for the index of collection types for the account.
    /// </summary>
    [JsonPropertyName("_links")]
    public LinksForAccountProfile Links { get; init; }

    /// <summary>
    /// Gets a link to the pets collection for the account.
    /// </summary>
    [JsonPropertyName("pets")]
    public Self Pets { get; init; }

    /// <summary>
    /// Gets a link to the mounts collection for the account.
    /// </summary>
    [JsonPropertyName("mounts")]
    public Self Mounts { get; init; }
}
