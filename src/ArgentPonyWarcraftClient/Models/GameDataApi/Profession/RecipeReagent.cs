namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reagent for a recipe.
/// </summary>
public record RecipeReagent
{
    /// <summary>
    /// Gets a reference to the reagent item.
    /// </summary>
    [JsonPropertyName("reagent")]
    public ItemReference Reagent { get; init; }

    /// <summary>
    /// Gets the quantity of the reagent required.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int Quantity { get; init; }
}
