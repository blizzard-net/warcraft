namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to any achievement.
/// </summary>
public record AchievementReference
{
    /// <summary>
    /// Gets the key for this achievement.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of this achievement.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of this achievement.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
