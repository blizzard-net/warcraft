namespace ArgentPonyWarcraftClient;

/// <summary>
/// A character's profession.
/// </summary>
public record CharacterProfession
{
    /// <summary>
    /// Gets a reference to the profession.
    /// </summary>
    [JsonPropertyName("profession")]
    public ProfessionReference Profession { get; init; }

    /// <summary>
    /// Gets the skill tiers for t
    /// </summary>
    [JsonPropertyName("tiers")]
    public CharacterSkillTier[] Tiers { get; init; }

    /// <summary>
    /// Gets the character's skill points in this profession.
    /// </summary>
    [JsonPropertyName("skill_points")]
    public int? SkillPoints { get; init; }

    /// <summary>
    /// Gets the character's maximum skill points in this profession.
    /// </summary>
    [JsonPropertyName("max_skill_points")]
    public int? MaxSkillPoints { get; init; }
}
