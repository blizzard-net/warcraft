namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to an achievement category.
/// </summary>
public record AchievementCategoryReference
{
    /// <summary>
    /// Gets the key for this achievement category.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of this achievement category.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of this achievement category.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
