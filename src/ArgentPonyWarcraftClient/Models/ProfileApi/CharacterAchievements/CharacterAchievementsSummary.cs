namespace ArgentPonyWarcraftClient;

/// <summary>
/// A summary of the achievements a character has completed.
/// </summary>
public record CharacterAchievementsSummary
{
    /// <summary>
    /// Gets links for the character achievements summary.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the total number of achievements for this character.
    /// </summary>
    [JsonPropertyName("total_quantity")]
    public int TotalQuantity { get; init; }

    /// <summary>
    /// Gets the total number of achievement points for this character.
    /// </summary>
    [JsonPropertyName("total_points")]
    public int TotalPoints { get; init; }

    /// <summary>
    /// Gets the achievements for this character.
    /// </summary>
    [JsonPropertyName("achievements")]
    public AchievementProgress[] Achievements { get; init; }

    /// <summary>
    /// Gets the character's progress in various achievement categories.
    /// </summary>
    [JsonPropertyName("category_progress")]
    public CategoryProgress[] CategoryProgress { get; init; }

    /// <summary>
    /// Gets recent achievements by the character.
    /// </summary>
    [JsonPropertyName("recent_events")]
    public RecentEvent[] RecentEvents { get; init; }

    /// <summary>
    /// Gets a reference to the character.
    /// </summary>
    [JsonPropertyName("character")]
    public CharacterReference Character { get; init; }

    /// <summary>
    /// Gets a link to the character's achievement statistics.
    /// </summary>
    [JsonPropertyName("statistics")]
    public Self Statistics { get; init; }
}
