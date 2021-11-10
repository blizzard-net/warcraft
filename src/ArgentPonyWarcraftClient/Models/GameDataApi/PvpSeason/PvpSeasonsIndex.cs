namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of PvP seasons.
/// </summary>
public record PvpSeasonsIndex
{
    /// <summary>
    /// Gets links for the index of PvP seasons.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets references to the PvP seasons.
    /// </summary>
    [JsonPropertyName("seasons")]
    public PvpSeasonReference[] Seasons { get; init; }

    /// <summary>
    /// Gets a reference to the current PvP season.
    /// </summary>
    [JsonPropertyName("current_season")]
    public PvpSeasonReference CurrentSeason { get; init; }
}
