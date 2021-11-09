namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a spell.
/// </summary>
public record SpellReference
{
    /// <summary>
    /// Gets the key for the spell.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the spell.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the spell.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
