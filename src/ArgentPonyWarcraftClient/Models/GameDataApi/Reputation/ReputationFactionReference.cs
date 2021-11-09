namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a reputation faction.
/// </summary>
public record ReputationFactionReference
{
    /// <summary>
    /// Gets the key for the reputation faction.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the reputation faction.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the reputation faction.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
