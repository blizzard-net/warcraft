namespace ArgentPonyWarcraftClient;

/// <summary>
/// Corruption statistics.
/// </summary>
public record CorruptionStatistics
{
    /// <summary>
    /// Gets the corruption level.
    /// </summary>
    [JsonPropertyName("corruption")]
    public float Corruption { get; init; }

    /// <summary>
    /// Gets the corruption resistance.
    /// </summary>
    [JsonPropertyName("corruption_resistance")]
    public float CorruptionResistance { get; init; }

    /// <summary>
    /// Gets the effective corruption.
    /// </summary>
    [JsonPropertyName("effective_corruption")]
    public float EffectiveCorruption { get; init; }
}
