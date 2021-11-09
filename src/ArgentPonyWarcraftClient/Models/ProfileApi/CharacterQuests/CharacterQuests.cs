namespace ArgentPonyWarcraftClient;

/// <summary>
/// A character's active quests as well as a link to the character's completed quests.
/// </summary>
public record CharacterQuests
{
    /// <summary>
    /// Gets links for the character quests.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a reference to the character.
    /// </summary>
    [JsonPropertyName("character")]
    public CharacterReference Character { get; init; }

    /// <summary>
    /// Gets references to the character's in-progress quests.
    /// </summary>
    [JsonPropertyName("in_progress")]
    public QuestReference[] InProgress { get; init; }

    /// <summary>
    /// Gets a link to the character's completed quests.
    /// </summary>
    [JsonPropertyName("completed")]
    public Self Completed { get; init; }
}
