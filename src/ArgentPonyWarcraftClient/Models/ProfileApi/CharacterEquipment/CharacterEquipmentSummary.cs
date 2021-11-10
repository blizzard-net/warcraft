namespace ArgentPonyWarcraftClient;

/// <summary>
/// A summary of the items equipped by a character.
/// </summary>
public record CharacterEquipmentSummary
{
    /// <summary>
    /// Gets links for the character equipment summary.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a reference to the character.
    /// </summary>
    [JsonPropertyName("character")]
    public CharacterReference Character { get; init; }

    /// <summary>
    /// Gets the character's equipped items.
    /// </summary>
    [JsonPropertyName("equipped_items")]
    public EquippedItem[] EquippedItems { get; init; }
}
