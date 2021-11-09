namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of reputation factions.
/// </summary>
public record ReputationFactionsIndex
{
    /// <summary>
    /// Gets links for the index of reputation factions.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets references to the factions.
    /// </summary>
    [JsonPropertyName("factions")]
    public ReputationFactionReference[] Factions { get; init; }

    /// <summary>
    /// Gets references to the root factions.
    /// </summary>
    [JsonPropertyName("root_factions")]
    public ReputationFactionReference[] RootFactions { get; init; }
}
