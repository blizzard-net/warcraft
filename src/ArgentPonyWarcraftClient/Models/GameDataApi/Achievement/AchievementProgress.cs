namespace ArgentPonyWarcraftClient;

/// <summary>
/// An achievement for a character or guild.
/// </summary>
public record AchievementProgress
{
    /// <summary>
    /// Gets the ID of the achievement.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets a reference to the achievement.
    /// </summary>
    [JsonPropertyName("achievement")]
    public AchievementReference Achievement { get; init; }

    /// <summary>
    /// Gets the criteria for the achievement.
    /// </summary>
    [JsonPropertyName("criteria")]
    public Criteria Criteria { get; init; }

    /// <summary>
    /// Gets the timestamp when the character or guild completed the achievement, or <c>null</c> if it has not been completed.
    /// </summary>
    [JsonPropertyName("completed_timestamp")]
    public DateTimeOffset? CompletedTimestamp { get; init; }
}
