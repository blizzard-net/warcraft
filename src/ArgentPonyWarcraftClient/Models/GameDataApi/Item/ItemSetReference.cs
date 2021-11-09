namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to an item set.
/// </summary>
public record ItemSetReference
{
    /// <summary>
    /// Gets the key for the item set.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the item set.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the item set.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
