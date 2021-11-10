namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of achievement categories.
/// </summary>
public record AchievementCategoriesIndex
{
    /// <summary>
    /// Gets links for the index of achievement categories.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets references to achievement categories.
    /// </summary>
    [JsonPropertyName("categories")]
    public AchievementCategoryReference[] Categories { get; init; }

    /// <summary>
    /// Gets references to root achievement categories.
    /// </summary>
    [JsonPropertyName("root_categories")]
    public AchievementCategoryReference[] RootCategories { get; init; }

    /// <summary>
    /// Gets references to guild achievement categories.
    /// </summary>
    [JsonPropertyName("guild_categories")]
    public AchievementCategoryReference[] GuildCategories { get; init; }
}
