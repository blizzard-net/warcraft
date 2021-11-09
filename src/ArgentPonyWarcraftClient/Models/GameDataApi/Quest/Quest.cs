namespace ArgentPonyWarcraftClient;

/// <summary>
/// A quest.
/// </summary>
public record Quest
{
    /// <summary>
    /// Gets links for the quest.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of the quest.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the title of the quest.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; init; }

    /// <summary>
    /// Gets a reference to the area for the quest.
    /// </summary>
    [JsonPropertyName("area")]
    public QuestAreaReference Area { get; init; }

    /// <summary>
    /// Gets the description of the quest.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; init; }

    /// <summary>
    /// Gets the requirements for the quest.
    /// </summary>
    [JsonPropertyName("requirements")]
    public QuestRequirements Requirements { get; init; }

    /// <summary>
    /// Gets the quest rewards.
    /// </summary>
    [JsonPropertyName("rewards")]
    public QuestReward Rewards { get; init; }
}
