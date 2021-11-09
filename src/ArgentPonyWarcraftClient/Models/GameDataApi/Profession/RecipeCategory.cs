namespace ArgentPonyWarcraftClient;

/// <summary>
/// A recipe category.
/// </summary>
public record RecipeCategory
{
    /// <summary>
    /// Gets the name of the recipe category.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the recipes in the recipe category.
    /// </summary>
    [JsonPropertyName("recipes")]
    public RecipeReference[] Recipes { get; init; }
}
