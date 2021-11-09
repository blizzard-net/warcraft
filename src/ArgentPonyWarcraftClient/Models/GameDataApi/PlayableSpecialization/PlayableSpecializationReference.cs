namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a playable specialization.
/// </summary>
public record PlayableSpecializationReference
{
    /// <summary>
    /// Gets the key for the playable specialization.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the playable specialization.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the playable specialization.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
