namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a skill tier.
/// </summary>
public record SkillTierReference
{
    /// <summary>
    /// Gets the key for the skill tier.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the skill tier.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the skill tier.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
