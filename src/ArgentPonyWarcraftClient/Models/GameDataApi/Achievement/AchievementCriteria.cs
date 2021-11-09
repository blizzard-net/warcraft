namespace ArgentPonyWarcraftClient;

/// <summary>
/// Criteria for an achievement.
/// </summary>
public record AchievementCriteria
{
    /// <summary>
    /// Gets the ID of the criteria.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the description of the criteria.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; init; }

    /// <summary>
    /// Gets the amount of the criteria.
    /// </summary>
    [JsonPropertyName("amount")]
    public int Amount { get; init; }
}
