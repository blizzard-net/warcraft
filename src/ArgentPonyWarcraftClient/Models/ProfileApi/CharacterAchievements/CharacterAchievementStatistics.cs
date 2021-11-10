namespace ArgentPonyWarcraftClient;

/// <summary>
/// A character's statistics as they pertain to achievements.
/// </summary>
public record CharacterAchievementStatistics
{
    /// <summary>
    /// Gets links for the character achievement statistics.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a reference to the character.
    /// </summary>
    [JsonPropertyName("character")]
    public CharacterReference Character { get; init; }

    /// <summary>
    /// Get the character achievement statistic categories.
    /// </summary>
    [JsonPropertyName("categories")]
    public Category[] Categories { get; init; }
}
