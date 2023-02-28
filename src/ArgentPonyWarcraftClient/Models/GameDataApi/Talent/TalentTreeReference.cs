namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a talent tree.
/// </summary>
public record TalentTreeReference
{
    /// <summary>
    /// Gets the key for the talent tree.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the talent tree.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }
}
