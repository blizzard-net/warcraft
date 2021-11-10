namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a boss encounter in a dungeon or raid.
/// </summary>
public record EncounterReference
{
    /// <summary>
    /// Gets the key for the encounter.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the encounter.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the encounter.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
