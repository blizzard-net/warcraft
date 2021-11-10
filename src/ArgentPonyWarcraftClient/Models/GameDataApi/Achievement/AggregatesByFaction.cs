namespace ArgentPonyWarcraftClient;

/// <summary>
/// Achievement aggregates by faction.
/// </summary>
public record AggregatesByFaction
{
    /// <summary>
    /// Gets the aggregates for the Alliance.
    /// </summary>
    [JsonPropertyName("alliance")]
    public FactionAchievementAggregates Alliance { get; init; }

    /// <summary>
    /// Gets the aggregates for the Horde.
    /// </summary>
    [JsonPropertyName("horde")]
    public FactionAchievementAggregates Horde { get; init; }
}
