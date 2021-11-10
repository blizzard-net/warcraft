namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a talent.
/// </summary>
public record TalentReference
{
    /// <summary>
    /// Gets the key for the talent.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the talent.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the talent.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
