namespace ArgentPonyWarcraftClient;

/// <summary>
/// A character achievement statistic category.
/// </summary>
public record Category
{
    /// <summary>
    /// Gets the ID of the category.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the name of the category.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the subcategories of the category, if any.
    /// </summary>
    [JsonPropertyName("sub_categories")]
    public Category[] SubCategories { get; init; }

    /// <summary>
    /// Gets the character achievement statistics in the category.
    /// </summary>
    [JsonPropertyName("statistics")]
    public Statistic[] Statistics { get; init; }
}
