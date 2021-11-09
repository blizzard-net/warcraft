namespace ArgentPonyWarcraftClient;

/// <summary>
/// A set of reputation tiers.
/// </summary>
public record ReputationTiers
{
    /// <summary>
    /// Gets links for the set of reputation tiers.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of the set of reputation tiers.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the reputation tiers.
    /// </summary>
    [JsonPropertyName("tiers")]
    public ReputationTier[] Tiers { get; init; }

    /// <summary>
    /// Gets a reference to the reputation faction.
    /// </summary>
    [JsonPropertyName("faction")]
    public ReputationFactionReference Faction { get; init; }
}
