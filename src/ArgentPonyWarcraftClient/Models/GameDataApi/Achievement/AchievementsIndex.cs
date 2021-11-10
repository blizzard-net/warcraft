namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of achievements.
/// </summary>
public record AchievementsIndex
{
    /// <summary>
    /// Gets links for the index of achievements.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets references to achievements.
    /// </summary>
    [JsonPropertyName("achievements")]
    public AchievementReference[] Achievements { get; init; }
}
