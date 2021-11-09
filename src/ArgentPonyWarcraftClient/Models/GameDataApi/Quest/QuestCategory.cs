namespace ArgentPonyWarcraftClient;

/// <summary>
/// A quest category.
/// </summary>
public record QuestCategory
{
    /// <summary>
    /// Gets links for the quest category.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of the quest category.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the quest category name.
    /// </summary>
    [JsonPropertyName("category")]
    public string Category { get; init; }

    /// <summary>
    /// Gets references to the quests in this category.
    /// </summary>
    [JsonPropertyName("quests")]
    public QuestReference[] Quests { get; init; }
}
