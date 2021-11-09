namespace ArgentPonyWarcraftClient;

/// <summary>
/// A recipe.
/// </summary>
public record Recipe
{
    /// <summary>
    /// Gets links for the recipe.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of the recipe.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the name of the recipe.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the description of the recipe.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; init; }

    /// <summary>
    /// Gets the media associated with the recipe.
    /// </summary>
    [JsonPropertyName("media")]
    public Media Media { get; init; }

    /// <summary>
    /// Gets a reference to the item crafted by this recipe.
    /// </summary>
    [JsonPropertyName("crafted_item")]
    public ItemReference CraftedItem { get; init; }

    /// <summary>
    /// Gets a reference to the Alliance version of the item crafted by this recipe.
    /// </summary>
    [JsonPropertyName("alliance_crafted_item")]
    public ItemReference AllianceCraftedItem { get; init; }

    /// <summary>
    /// Gets a reference to the Horde version of the item crafted by this recipe.
    /// </summary>
    [JsonPropertyName("horde_crafted_item")]
    public ItemReference HordeCraftedItem { get; init; }

    /// <summary>
    /// Gets the reagents required for the recipe.
    /// </summary>
    [JsonPropertyName("reagents")]
    public RecipeReagent[] Reagents { get; init; }

    /// <summary>
    /// Gets the range of item quantities produced by this recipe.
    /// </summary>
    [JsonPropertyName("crafted_quantity")]
    public CraftedQuantity CraftedQuantity { get; init; }

    /// <summary>
    /// Gets the modified crafting slots for this recipe.
    /// </summary>
    [JsonPropertyName("modified_crafting_slots")]
    public ModifiedCraftingSlot[] ModifiedCraftingSlots { get; init; }
}
