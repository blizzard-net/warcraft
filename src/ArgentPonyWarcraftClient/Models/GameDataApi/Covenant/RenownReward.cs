namespace ArgentPonyWarcraftClient;

/// <summary>
/// A covenant renown reward.
/// </summary>
public record RenownReward
{
    /// <summary>
    /// Gets the renown level that the reward is earned at.
    /// </summary>
    [JsonPropertyName("level")]
    public int Level { get; init; }

    /// <summary>
    /// Gets the reward reference.
    /// </summary>
    [JsonPropertyName("reward")]
    public CovenantRewardReference Reward { get; init; }
}
