namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of quest categories (such as quests for a specific class, profession, or storyline).
/// </summary>
public record QuestCategoriesIndex
{
    /// <summary>
    /// Gets links for the index of quest categories.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets references to the quest categories.
    /// </summary>
    [JsonPropertyName("categories")]
    public QuestCategoryReference[] Categories { get; init; }
}
