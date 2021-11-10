namespace ArgentPonyWarcraftClient;

/// <summary>
/// A character statistic.
/// </summary>
public record PrimaryStatistic
{
    /// <summary>
    /// Gets the base statistic.
    /// </summary>
    [JsonPropertyName("base")]
    public int Base { get; init; }

    /// <summary>
    /// Gets the effective statistic.
    /// </summary>
    [JsonPropertyName("effective")]
    public int Effective { get; init; }
}
