namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a quest type.
/// </summary>
public record QuestTypeReference
{
    /// <summary>
    /// Gets the key for the quest type.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the quest type.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the quest type.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
