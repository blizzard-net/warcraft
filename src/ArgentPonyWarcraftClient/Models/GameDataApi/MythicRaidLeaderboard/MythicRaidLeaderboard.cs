namespace ArgentPonyWarcraftClient;

/// <summary>
/// The Mythic Raid leaderboard for a given raid and faction.
/// </summary>
public record MythicRaidLeaderboard
{
    /// <summary>
    /// Gets links for the Mythic Raid leaderboard.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the slug for the raid and faction.
    /// </summary>
    [JsonPropertyName("slug")]
    public string Slug { get; init; }

    /// <summary>
    /// Gets the criteria type.
    /// </summary>
    [JsonPropertyName("criteria_type")]
    public string CriteriaType { get; init; }

    /// <summary>
    /// Gets the entries for the Mythic Raid leaderboard.
    /// </summary>
    [JsonPropertyName("entries")]
    public MythicRaidLeaderboardEntry[] Entries { get; init; }

    /// <summary>
    /// Gets a reference to journal instance for the raid.
    /// </summary>
    [JsonPropertyName("journal_instance")]
    public InstanceReference JournalInstance { get; init; }
}
