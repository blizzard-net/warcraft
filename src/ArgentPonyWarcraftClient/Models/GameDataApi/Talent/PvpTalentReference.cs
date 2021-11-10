namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a PvP talent.
/// </summary>
public record PvpTalentReference
{
    /// <summary>
    /// Gets the key for the PvP talent.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the PvP talent.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the PvP talent.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
