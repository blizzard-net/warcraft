namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of boss encounters.
/// </summary>
public record JournalEncountersIndex
{
    /// <summary>
    /// Gets links for the index of boss encounters.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the boss encounters.
    /// </summary>
    [JsonPropertyName("encounters")]
    public EncounterReference[] Encounters { get; init; }
}
