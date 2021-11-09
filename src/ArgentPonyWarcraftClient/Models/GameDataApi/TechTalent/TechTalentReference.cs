namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a tech talent.
/// </summary>
public record TechTalentReference
{
    /// <summary>
    /// Gets the key for the tech talent.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the tech talent.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the tech talent.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
