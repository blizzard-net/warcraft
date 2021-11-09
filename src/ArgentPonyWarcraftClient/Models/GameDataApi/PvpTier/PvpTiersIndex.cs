namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of PvP tiers.
/// </summary>
public record PvpTiersIndex
{
    /// <summary>
    /// Gets links for the index of PvP tiers.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets references to the PvP tiers.
    /// </summary>
    [JsonPropertyName("tiers")]
    public PvpTierReference[] Tiers { get; init; }
}
