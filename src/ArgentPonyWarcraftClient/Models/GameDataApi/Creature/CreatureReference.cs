namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a creature.
/// </summary>
public record CreatureReference
{
    /// <summary>
    /// Gets the key for the creature.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the creature.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the creature.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
