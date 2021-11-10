namespace ArgentPonyWarcraftClient;

/// <summary>
/// A tech talent.
/// </summary>
public record TechTalent
{
    /// <summary>
    /// Gets links for the tech talent.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the Id for the tech talent.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the tech talent tree reference for the tech talent.
    /// </summary>
    [JsonPropertyName("talent_tree")]
    public TechTalentTreeReference TalentTree { get; init; }

    /// <summary>
    /// Gets the name for the tech talent.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets a description for the tech talent.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; init; }

    /// <summary>
    /// Gets the spell tooltip for this tech talent.
    /// </summary>
    [JsonPropertyName("spell_tooltip")]
    public SpellTooltipForAbility SpellTooltip { get; init; }

    /// <summary>
    /// Gets the tier for the tech talent.
    /// </summary>
    [JsonPropertyName("tier")]
    public int Tier { get; init; }

    /// <summary>
    /// Gets the display order for the tech talent.
    /// </summary>
    [JsonPropertyName("display_order")]
    public int DisplayOrder { get; init; }

    /// <summary>
    /// Gets the prerequisite talent for the tech talent.
    /// </summary>
    [JsonPropertyName("prerequisite_talent")]
    public TalentReference PrerequisiteTalent { get; init; }

    /// <summary>
    /// Gets the media for the tech talent.
    /// </summary>
    [JsonPropertyName("media")]
    public Media Media { get; init; }
}
