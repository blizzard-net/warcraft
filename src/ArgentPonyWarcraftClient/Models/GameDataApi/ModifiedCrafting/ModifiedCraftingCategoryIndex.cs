namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of Modified Crafting categories.
/// </summary>
public record ModifiedCraftingCategoryIndex
{
    /// <summary>
    /// Gets links for the index of Modified Crafting categories.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets references to the Modified Crafting categories.
    /// </summary>
    [JsonPropertyName("categories")]
    public ModifiedCraftingCategoryReference[] Categories { get; init; }
}
