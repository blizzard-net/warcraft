namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a Mythic Keystone Leaderboard dungeon instance for a connected realm.
/// </summary>
public record MythicKeystoneLeaderboardReference
{
    /// <summary>
    /// Gets the key for the Mythic Keystone Leaderboard.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the Mythic Keystone Leaderboard.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the Mythic Keystone Leaderboard.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
