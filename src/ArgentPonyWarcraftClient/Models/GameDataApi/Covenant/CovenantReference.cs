namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a covenant.
/// </summary>
public record CovenantReference
{
    /// <summary>
    /// Gets the key for the covenant.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the covenant.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the covenant.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
