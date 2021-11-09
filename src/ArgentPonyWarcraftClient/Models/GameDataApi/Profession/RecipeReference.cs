namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a recipe.
/// </summary>
public record RecipeReference
{
    /// <summary>
    /// Gets the key for the recipe.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the recipe.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the recipe.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
