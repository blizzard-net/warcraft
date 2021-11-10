namespace ArgentPonyWarcraftClient;

/// <summary>
/// A set of quest requirements.
/// </summary>
public record QuestRequirements
{
    /// <summary>
    /// Gets the minimum character level for the quest.
    /// </summary>
    [JsonPropertyName("min_character_level")]
    public int MinCharacterLevel { get; init; }

    /// <summary>
    /// Gets the maximum character level for the quest.
    /// </summary>
    [JsonPropertyName("max_character_level")]
    public int MaxCharacterLevel { get; init; }

    /// <summary>
    /// Gets the faction for the question (Alliance or Horde).
    /// </summary>
    [JsonPropertyName("faction")]
    public EnumType Faction { get; init; }
}
