namespace ArgentPonyWarcraftClient;

/// <summary>
/// A recent achievement by a character or guild.
/// </summary>
public record RecentEvent
{
    /// <summary>
    /// Gets a reference to the achievement.
    /// </summary>
    [JsonPropertyName("achievement")]
    public AchievementReference Achievement { get; init; }

    /// <summary>
    /// Gets the timestamp when the achievement was completed.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public DateTimeOffset Timestamp { get; init; }
}
