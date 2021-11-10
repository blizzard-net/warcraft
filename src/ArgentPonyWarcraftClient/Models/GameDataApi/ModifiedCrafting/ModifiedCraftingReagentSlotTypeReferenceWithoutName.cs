namespace ArgentPonyWarcraftClient;

/// <summary>
/// A Modified Crafting reagent slot type.
/// </summary>
public record ModifiedCraftingReagentSlotTypeReferenceWithoutName
{
    /// <summary>
    /// Gets the key for the Modified Crafting reagent slot type.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the ID of the Modified Crafting reagent slot type.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
