namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a Modified Crafting category.
/// </summary>
public record ModifiedCraftingCategoryReference
{
    /// <summary>
    /// Gets the key for the Modified Crafting category.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the Modified Crafting category.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the Modified Crafting category.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
