namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of game expansions.
/// </summary>
public record JournalExpansionsIndex
{
    /// <summary>
    /// Gets links for the index of game expansions.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the tiers of content for the game expansions.
    /// </summary>
    [JsonPropertyName("tiers")]
    public Tier[] Tiers { get; init; }
}
