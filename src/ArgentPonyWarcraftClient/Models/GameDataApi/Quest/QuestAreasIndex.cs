namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of quest areas.
/// </summary>
public record QuestAreasIndex
{
    /// <summary>
    /// Gets links for the index of quest areas.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets references to the quest areas.
    /// </summary>
    [JsonPropertyName("areas")]
    public QuestAreaReference[] Areas { get; init; }
}
