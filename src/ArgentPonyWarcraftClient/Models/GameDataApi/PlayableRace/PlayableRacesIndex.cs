namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of playable races.
/// </summary>
public record PlayableRacesIndex
{
    /// <summary>
    /// Gets links for the index of playable races.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets references to the playable races.
    /// </summary>
    [JsonPropertyName("races")]
    public PlayableRaceReference[] Races { get; init; }
}
