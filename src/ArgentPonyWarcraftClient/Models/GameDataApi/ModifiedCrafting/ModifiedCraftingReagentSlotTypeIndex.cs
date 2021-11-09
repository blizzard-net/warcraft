namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of Modified Crafting reagent slot types.
/// </summary>
public record ModifiedCraftingReagentSlotTypeIndex
{
    /// <summary>
    /// Gets links for the index of Modified Crafting reagent slot types.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets references to the Modified Crafting reagent slot types.
    /// </summary>
    [JsonPropertyName("slot_types")]
    public ModifiedCraftingReagentSlotTypeReference[] SlotTypes { get; init; }
}
