namespace ArgentPonyWarcraftClient;

/// <summary>
/// Progress in an achievement category for a character.
/// </summary>
public record CategoryProgress
{
    /// <summary>
    /// Gets a reference to the achievement category.
    /// </summary>
    [JsonPropertyName("category")]
    public AchievementCategoryReference Category { get; init; }

    /// <summary>
    /// Gets the number of achievements the character has in this category.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int Quantity { get; init; }

    /// <summary>
    /// Gets the number of achievement points the character has in this category.
    /// </summary>
    [JsonPropertyName("points")]
    public int Points { get; init; }
}
