namespace ArgentPonyWarcraftClient;

/// <summary>
/// An Enchantment.
/// </summary>
public record Enchantment
{
    /// <summary>
    /// Gets the display string for the enchantment.
    /// </summary>
    [JsonPropertyName("display_string")]
    public string DisplayString { get; init; }

    /// <summary>
    /// Gets the enchantment ID for the enchantment.
    /// </summary>
    [JsonPropertyName("enchantment_id")]
    public int EnchantmentId { get; init; }

    /// <summary>
    /// Gets a reference to the item.
    /// </summary>
    [JsonPropertyName("source_item")]
    public ItemReference SourceItem { get; init; }
}
