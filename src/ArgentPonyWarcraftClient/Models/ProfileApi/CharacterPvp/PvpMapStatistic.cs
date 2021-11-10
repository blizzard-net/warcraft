namespace ArgentPonyWarcraftClient;

/// <summary>
/// PvP match statistic for a character in a specific world map.
/// </summary>
public record PvpMapStatistic
{
    /// <summary>
    /// Gets the world map.
    /// </summary>
    [JsonPropertyName("world_map")]
    public Map WorldMap { get; init; }

    /// <summary>
    /// Gets the character's PvP match statistics for the map.
    /// </summary>
    [JsonPropertyName("match_statistics")]
    public PvpMatchStatistics MatchStatistics { get; init; }
}
