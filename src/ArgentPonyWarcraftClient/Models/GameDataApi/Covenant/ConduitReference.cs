namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a conduit.
/// </summary>
public record ConduitReference
{
    /// <summary>
    /// Gets the key for the conduit.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the conduit.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the conduit.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
