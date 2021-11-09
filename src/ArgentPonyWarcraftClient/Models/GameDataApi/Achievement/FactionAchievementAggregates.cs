namespace ArgentPonyWarcraftClient;

/// <summary>
/// Achievement aggregates for a faction.
/// </summary>
public record FactionAchievementAggregates
{
    /// <summary>
    /// Gets the quantity.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int Quantity { get; init; }

    /// <summary>
    /// Gets the number of points.
    /// </summary>
    [JsonPropertyName("points")]
    public int Points { get; init; }
}
