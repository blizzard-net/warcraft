namespace ArgentPonyWarcraftClient;

/// <summary>
/// A character's skill tier within a profession.
/// </summary>
public record CharacterSkillTier
{
    /// <summary>
    /// Gets the character's skill points in this profession skill tier.
    /// </summary>
    [JsonPropertyName("skill_points")]
    public int SkillPoints { get; init; }

    /// <summary>
    /// Gets the maximum possible skill points in this profession skill tier.
    /// </summary>
    [JsonPropertyName("max_skill_points")]
    public int MaxSkillPoints { get; init; }

    /// <summary>
    /// Gets a reference to the skill tier.
    /// </summary>
    [JsonPropertyName("tier")]
    public SkillTierReferenceWithoutKey Tier { get; init; }

    /// <summary>
    /// Gets references to the known recipes for this profession skill tier.
    /// </summary>
    [JsonPropertyName("known_recipes")]
    public RecipeReference[] KnownRecipes { get; init; }
}
