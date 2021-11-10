namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of Mythic Keystone Leaderboard dungeon instances for a connected realm.
/// </summary>
public record MythicKeystoneLeaderboardsIndex
{
    /// <summary>
    /// Gets links for the index of Mythic Keystone Leaderboards.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets references to the Mythic Keystone Leaderboards.
    /// </summary>
    [JsonPropertyName("current_leaderboards")]
    public MythicKeystoneLeaderboardReference[] CurrentLeaderboards { get; init; }
}
