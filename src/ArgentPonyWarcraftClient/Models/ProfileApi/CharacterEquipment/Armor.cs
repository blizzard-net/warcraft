namespace ArgentPonyWarcraftClient;

/// <summary>
/// Armor details for an item.
/// </summary>
public record Armor
{
    /// <summary>
    /// Gets the number of armor points for the item.
    /// </summary>
    [JsonPropertyName("value")]
    public int Value { get; init; }

    /// <summary>
    /// Gets a display information for the armor.
    /// </summary>
    [JsonPropertyName("display")]
    public NameDescription Display { get; init; }
}
