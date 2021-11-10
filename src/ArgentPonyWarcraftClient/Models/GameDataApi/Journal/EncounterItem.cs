namespace ArgentPonyWarcraftClient;

/// <summary>
/// An item that can appear as loot from an encounter.
/// </summary>
public record EncounterItem
{
    /// <summary>
    /// Gets the ID of the encounter item.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets a reference to the item.
    /// </summary>
    [JsonPropertyName("item")]
    public ItemReference Item { get; init; }
}
