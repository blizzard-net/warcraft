namespace ArgentPonyWarcraftClient;

/// <summary>
/// An entry in a Mythic Raid leaderboard.
/// </summary>
public record MythicRaidLeaderboardEntry
{
    /// <summary>
    /// Gets a reference to the guild.
    /// </summary>
    [JsonPropertyName("guild")]
    public GuildReferenceWithoutKeyAndFaction Guild { get; init; }

    /// <summary>
    /// Gets the faction.
    /// </summary>
    [JsonPropertyName("faction")]
    public EnumTypeWithoutName Faction { get; init; }

    /// <summary>
    /// Gets the timestamp.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public DateTimeOffset Timestamp { get; init; }

    /// <summary>
    /// Gets the region.
    /// </summary>
    [JsonPropertyName("region")]
    public string Region { get; init; }

    /// <summary>
    /// Gets the rank.
    /// </summary>
    [JsonPropertyName("rank")]
    public int Rank { get; init; }
}
