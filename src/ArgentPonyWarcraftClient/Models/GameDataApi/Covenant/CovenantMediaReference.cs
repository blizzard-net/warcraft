namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to media for a particular covenant.
/// </summary>
public record CovenantMediaReference
{
    /// <summary>
    /// Gets the key for the covenant media reference.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the Id for the covenant media reference.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
