namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to game expansion.
/// </summary>
public record ExpansionReference
{
    /// <summary>
    /// Gets the key for the expansion.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the expansion.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the expansion.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
