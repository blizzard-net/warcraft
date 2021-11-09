namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a playable class.
/// </summary>
public record PlayableClassReferenceWithoutName
{
    /// <summary>
    /// Gets the key for the playable class.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the ID of the playable class.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
