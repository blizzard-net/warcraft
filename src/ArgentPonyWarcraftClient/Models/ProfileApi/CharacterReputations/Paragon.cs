namespace ArgentPonyWarcraftClient;

/// <summary>
/// A character's paragon status with a reputation faction.
/// </summary>
public record Paragon
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
}
