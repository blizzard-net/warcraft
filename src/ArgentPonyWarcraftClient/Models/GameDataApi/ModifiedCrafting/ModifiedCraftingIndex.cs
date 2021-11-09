namespace ArgentPonyWarcraftClient;

/// <summary>
/// The parent index for Modified Crafting.
/// </summary>
public record ModifiedCraftingIndex
{
    /// <summary>
    /// Gets links for the parent index for Modified Crafting.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a reference to the index of Modified Crafting categories.
    /// </summary>
    [JsonPropertyName("categories")]
    public Self Categories { get; init; }

    /// <summary>
    /// Gets a reference to the Modified Crafting reagent slot types.
    /// </summary>
    [JsonPropertyName("slot_types")]
    public Self SlotTypes { get; init; }
}
