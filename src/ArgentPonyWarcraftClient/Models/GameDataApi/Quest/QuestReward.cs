namespace ArgentPonyWarcraftClient;

/// <summary>
/// A quest reward.
/// </summary>
public record QuestReward
{
    /// <summary>
    /// Gets the number of experience points granted for completing the quest.
    /// </summary>
    [JsonPropertyName("experience")]
    public int Experience { get; init; }

    /// <summary>
    /// Gets the reputation gains for completing the quest.
    /// </summary>
    [JsonPropertyName("reputations")]
    public ReputationReward[] Reputations { get; init; }

    /// <summary>
    /// Get the monetary reward for completing the quest.
    /// </summary>
    [JsonPropertyName("money")]
    public Money Money { get; init; }
}
