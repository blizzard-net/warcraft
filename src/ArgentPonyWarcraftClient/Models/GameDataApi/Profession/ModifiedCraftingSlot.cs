namespace ArgentPonyWarcraftClient;

/// <summary>
/// A Modified Crafting slot.
/// </summary>
public record ModifiedCraftingSlot
{
    /// <summary>
    /// Gets the slot type of the Modified Crafting slot.
    /// </summary>
    [JsonPropertyName("slot_type")]
    public ModifiedCraftingReagentSlotTypeReferenceWithoutName SlotType { get; init; }

    /// <summary>
    /// Gets the display order of the Modified Crafting slot.
    /// </summary>
    [JsonPropertyName("display_order")]
    public int DisplayOrder { get; init; }
}
