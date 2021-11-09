namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a creature type.
/// </summary>
public record CreatureTypeReference
{
    /// <summary>
    /// Gets the key for the creature type.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the creature type.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the creature type.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
