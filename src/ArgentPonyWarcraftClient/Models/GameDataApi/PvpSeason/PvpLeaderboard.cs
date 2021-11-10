namespace ArgentPonyWarcraftClient;

/// <summary>
/// A PvP leaderboard of a specific PvP bracket for a PvP season.
/// </summary>
public record PvpLeaderboard
{
    /// <summary>
    /// Gets links for the PvP Leaderboard.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a reference to the PvP season.
    /// </summary>
    [JsonPropertyName("season")]
    public PvpSeasonReference Season { get; init; }

    /// <summary>
    /// Gets the name of the PvP leaderboard.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// A PvP bracket.
    /// </summary>
    [JsonPropertyName("bracket")]
    public Bracket Bracket { get; init; }

    /// <summary>
    /// Gets the entries in the PvP leaderboard.
    /// </summary>
    [JsonPropertyName("entries")]
    public PvpLeaderboardEntry[] Entries { get; init; }
}
