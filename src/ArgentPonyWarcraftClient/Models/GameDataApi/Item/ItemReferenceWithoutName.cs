namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to an item.
/// </summary>
public record ItemReferenceWithoutName
{
    /// <summary>
    /// Gets the key for the item.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the ID of the item.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
