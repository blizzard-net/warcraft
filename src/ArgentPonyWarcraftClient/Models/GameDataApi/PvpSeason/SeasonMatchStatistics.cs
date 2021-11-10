namespace ArgentPonyWarcraftClient;

/// <summary>
/// PvP season match statistics.
/// </summary>
public record SeasonMatchStatistics
{
    /// <summary>
    /// Gets the number of matches played.
    /// </summary>
    [JsonPropertyName("played")]
    public int Played { get; init; }

    /// <summary>
    /// Gets the number of matches won.
    /// </summary>
    [JsonPropertyName("won")]
    public int Won { get; init; }

    /// <summary>
    /// Gets the number of matches lost.
    /// </summary>
    [JsonPropertyName("lost")]
    public int Lost { get; init; }
}
