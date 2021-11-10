namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to item media.
/// </summary>
public record ItemMediaReference
{
    /// <summary>
    /// Gets the key for the item media.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the ID of the item.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
