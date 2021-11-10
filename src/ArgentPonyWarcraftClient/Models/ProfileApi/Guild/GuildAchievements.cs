namespace ArgentPonyWarcraftClient;

/// <summary>
/// A guild's achievements.
/// </summary>
public record GuildAchievements
{
    /// <summary>
    /// Gets links for the guild's achievements.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a reference to the guild.
    /// </summary>
    [JsonPropertyName("guild")]
    public GuildReference Guild { get; init; }

    /// <summary>
    /// Gets the total number of guild achievements.
    /// </summary>
    [JsonPropertyName("total_quantity")]
    public int TotalQuantity { get; init; }

    /// <summary>
    /// Gets the total number of guild achievement points.
    /// </summary>
    [JsonPropertyName("total_points")]
    public int TotalPoints { get; init; }

    /// <summary>
    /// Gets the guild achievements.
    /// </summary>
    [JsonPropertyName("achievements")]
    public AchievementProgress[] Achievements { get; init; }

    /// <summary>
    /// Gets the guild's progress in various achievement categories.
    /// </summary>
    [JsonPropertyName("category_progress")]
    public CategoryProgress[] CategoryProgress { get; init; }

    /// <summary>
    /// Gets recent achievements by the guild.
    /// </summary>
    [JsonPropertyName("recent_events")]
    public RecentEvent[] RecentEvents { get; init; }
}
