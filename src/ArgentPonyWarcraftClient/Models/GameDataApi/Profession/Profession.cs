namespace ArgentPonyWarcraftClient;

/// <summary>
/// A profession.
/// </summary>
public record Profession
{
    /// <summary>
    /// Gets links for the profession.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of the profession.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the name of the profession.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets a description of the profession.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; init; }

    /// <summary>
    /// Gets the type of the profession.
    /// </summary>
    [JsonPropertyName("type")]
    public EnumType Type { get; init; }

    /// <summary>
    /// Gets media associated with the profession.
    /// </summary>
    [JsonPropertyName("media")]
    public Media Media { get; init; }

    /// <summary>
    /// Gets references to the skill tiers for the profession.
    /// </summary>
    [JsonPropertyName("skill_tiers")]
    public SkillTierReference[] SkillTiers { get; init; }
}
