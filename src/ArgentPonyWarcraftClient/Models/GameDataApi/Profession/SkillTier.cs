namespace ArgentPonyWarcraftClient;

/// <summary>
/// A skill tier for a profession.
/// </summary>
public record SkillTier
{
    /// <summary>
    /// Gets links for the skill tier.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of the skill tier.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the name of the skill tier.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the minimum skill level for the skill tier.
    /// </summary>
    [JsonPropertyName("minimum_skill_level")]
    public int MinimumSkillLevel { get; init; }

    /// <summary>
    /// Gets the maximum skill level for the skill tier.
    /// </summary>
    [JsonPropertyName("maximum_skill_level")]
    public int MaximumSkillLevel { get; init; }

    /// <summary>
    /// Gets the categories in the skill tier.
    /// </summary>
    [JsonPropertyName("categories")]
    public RecipeCategory[] Categories { get; init; }
}
