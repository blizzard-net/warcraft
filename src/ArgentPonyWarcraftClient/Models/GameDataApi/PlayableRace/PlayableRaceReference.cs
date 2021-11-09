namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a playable race.
/// </summary>
public record PlayableRaceReference
{
    /// <summary>
    /// Gets the key for the playable race.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the playable race.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the playable race.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
