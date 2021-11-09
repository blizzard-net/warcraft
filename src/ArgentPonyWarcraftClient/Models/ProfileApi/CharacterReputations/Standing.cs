namespace ArgentPonyWarcraftClient;

/// <summary>
/// A character's standing with a reputation faction.
/// </summary>
public record Standing
{
    /// <summary>
    /// Gets the raw number.
    /// </summary>
    [JsonPropertyName("raw")]
    public int Raw { get; init; }

    /// <summary>
    /// Gets the value.
    /// </summary>
    [JsonPropertyName("value")]
    public int Value { get; init; }

    /// <summary>
    /// Gets the maximum value.
    /// </summary>
    [JsonPropertyName("max")]
    public int Max { get; init; }

    /// <summary>
    /// Gets the reputation tier.
    /// </summary>
    [JsonPropertyName("tier")]
    public int Tier { get; init; }

    /// <summary>
    /// Gets the name of the standing.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }
}
