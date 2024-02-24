namespace ArgentPonyWarcraftClient;

/// <summary>
/// A leading group.
/// </summary>
public record LeadingGroup
{
    /// <summary>
    /// Gets the ranking of the group.
    /// </summary>
    [JsonPropertyName("ranking")]
    public int Ranking { get; init; }

    /// <summary>
    /// Gets the duration of the run.
    /// </summary>
    [JsonPropertyName("duration")]
    public TimeSpan Duration { get; init; }

    /// <summary>
    /// Gets the timestamp of the completion.
    /// </summary>
    [JsonPropertyName("completed_timestamp")]
    public DateTimeOffset CompletedTimestamp { get; init; }

    /// <summary>
    /// Gets the keystone level.
    /// </summary>
    [JsonPropertyName("keystone_level")]
    public int KeystoneLevel { get; init; }

    /// <summary>
    /// Gets the members of the group.
    /// </summary>
    [JsonPropertyName("members")]
    public Member[] Members { get; init; }

    /// <summary>
    /// Gets the rating of the run.
    /// </summary>
    [JsonPropertyName("mythic_rating")]
    public MythicRating MythicRating { get; init; }
}
