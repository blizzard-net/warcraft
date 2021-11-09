namespace ArgentPonyWarcraftClient;

/// <summary>
/// An achievement.
/// </summary>
public record Achievement
{
    /// <summary>
    /// Gets links for this achievement.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of this achievement.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets a reference to the achievement category to which this achievement belongs.
    /// </summary>
    [JsonPropertyName("category")]
    public AchievementCategoryReference Category { get; init; }

    /// <summary>
    /// Gets the name of this achievement.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the description of this achievement.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; init; }

    /// <summary>
    /// Gets the number of achievement points associated with this achievement.
    /// </summary>
    [JsonPropertyName("points")]
    public int Points { get; init; }

    /// <summary>
    /// Gets a value indicating whether this achievement is account-wide.
    /// </summary>
    [JsonPropertyName("is_account_wide")]
    public bool IsAccountWide { get; init; }

    /// <summary>
    /// Gets the criteria for this achievement.
    /// </summary>
    [JsonPropertyName("criteria")]
    public AchievementCriteria Criteria { get; init; }

    /// <summary>
    /// Gets a reference to the next achievement.
    /// </summary>
    [JsonPropertyName("next_achievement")]
    public AchievementReference NextAchievement { get; init; }

    /// <summary>
    /// Gets the media associated with this achievement.
    /// </summary>
    [JsonPropertyName("media")]
    public Media Media { get; init; }

    /// <summary>
    /// Gets the display order.
    /// </summary>
    [JsonPropertyName("display_order")]
    public int DisplayOrder { get; init; }
}
