namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a dungeon or raid.
/// </summary>
public record InstanceReference
{
    /// <summary>
    /// Gets the key for the instance.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the instance.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the instance.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
