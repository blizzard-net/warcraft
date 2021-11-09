namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reputation reward for completing a quest.
/// </summary>
public record ReputationReward
{
    /// <summary>
    /// Gets a reference to the reputation faction.
    /// </summary>
    [JsonPropertyName("reward")]
    public ReputationFactionReference Reward { get; init; }

    /// <summary>
    /// Gets the amount of reputation gained with the reputation faction.
    /// </summary>
    [JsonPropertyName("value")]
    public int Value { get; init; }
}
