namespace ArgentPonyWarcraftClient;

/// <summary>
/// A character statistic with a rating.
/// </summary>
public record RatingStatisticWithoutValue
{
    /// <summary>
    /// Gets the rating.
    /// </summary>
    [JsonPropertyName("rating")]
    public int Rating { get; init; }

    /// <summary>
    /// Gets the rating bonus.
    /// </summary>
    [JsonPropertyName("rating_bonus")]
    public float RatingBonus { get; init; }
}
