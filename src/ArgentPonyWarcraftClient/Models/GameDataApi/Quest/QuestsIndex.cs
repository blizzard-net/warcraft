namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of quests.
/// </summary>
public record QuestsIndex
{
    /// <summary>
    /// Gets links for the index of quests.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a reference to the quest categories.
    /// </summary>
    [JsonPropertyName("categories")]
    public Self Categories { get; init; }

    /// <summary>
    /// Gets a reference to the quest areas.
    /// </summary>
    [JsonPropertyName("areas")]
    public Self Areas { get; init; }

    /// <summary>
    /// Gets a reference to the quest types.
    /// </summary>
    [JsonPropertyName("types")]
    public Self Types { get; init; }
}
