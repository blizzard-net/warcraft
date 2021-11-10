namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of reputation tiers.
/// </summary>
public record ReputationTiersIndex
{
    /// <summary>
    /// Gets links for the index of reputation tiers.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets references to the reputation tiers.
    /// </summary>
    [JsonPropertyName("reputation_tiers")]
    public ReputationTierReference[] ReputationTiers { get; init; }
}
