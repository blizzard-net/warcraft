namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a quest area.
/// </summary>
public record QuestAreaReference
{
    /// <summary>
    /// Gets the key for the quest area.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the quest area.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the quest area.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
