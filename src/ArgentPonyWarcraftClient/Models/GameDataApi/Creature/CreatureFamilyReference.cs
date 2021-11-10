namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a creature family.
/// </summary>
public record CreatureFamilyReference
{
    /// <summary>
    /// Gets the key for the creature family.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the creature family.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the creature family.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
