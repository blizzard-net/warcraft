namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a profession.
/// </summary>
public record ProfessionReference
{
    /// <summary>
    /// Gets the key for the profession.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the profession.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the profession.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
