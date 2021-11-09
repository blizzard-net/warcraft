namespace ArgentPonyWarcraftClient;

/// <summary>
/// A list of quests that a character has completed.
/// </summary>
public record CharacterCompletedQuests
{
    /// <summary>
    /// Gets links for the character completed quests.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a reference to the character.
    /// </summary>
    [JsonPropertyName("character")]
    public CharacterReference Character { get; init; }

    /// <summary>
    /// Gets references to the character's completed quests.
    /// </summary>
    [JsonPropertyName("quests")]
    public QuestReference[] Quests { get; init; }
}
