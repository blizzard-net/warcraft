namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to creature display media.
/// </summary>
public record CreatureDisplayMediaReference
{
    /// <summary>
    /// Gets the key for the creature display media.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the ID of the creature display media.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
