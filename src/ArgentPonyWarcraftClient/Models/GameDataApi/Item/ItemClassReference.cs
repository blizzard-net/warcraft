namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to an item class.
/// </summary>
public record ItemClassReference
{
    /// <summary>
    /// Gets the key for the item class.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the item class.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the item class.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
