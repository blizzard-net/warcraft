namespace ArgentPonyWarcraftClient;

/// <summary>
/// A quest type (such as PvP quests, raid quests, or account quests).
/// </summary>
public record QuestType
{
    /// <summary>
    /// Gets links for the quest type.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of the quest type.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the quest type name.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; init; }

    /// <summary>
    /// Gets references to the quests of this type.
    /// </summary>
    [JsonPropertyName("quests")]
    public QuestReference[] Quests { get; init; }
}
