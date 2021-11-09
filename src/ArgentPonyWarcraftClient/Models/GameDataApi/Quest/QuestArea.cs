namespace ArgentPonyWarcraftClient;

/// <summary>
/// A quest area.
/// </summary>
public record QuestArea
{
    /// <summary>
    /// Gets links for the quest area.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of the quest area.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the quest area name.
    /// </summary>
    [JsonPropertyName("area")]
    public string Area { get; init; }

    /// <summary>
    /// Gets references to the quests in this area.
    /// </summary>
    [JsonPropertyName("quests")]
    public QuestReference[] Quests { get; init; }
}
