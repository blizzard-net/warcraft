namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a PvP leaderboard.
/// </summary>
public record PvpLeaderboardReference
{
    /// <summary>
    /// Gets the key for the PvP leaderboard.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the PvP leaderboard.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the PvP leaderboard.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
