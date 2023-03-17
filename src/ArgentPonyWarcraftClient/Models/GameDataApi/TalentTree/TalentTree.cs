namespace ArgentPonyWarcraftClient;

/// <summary>
/// Represents a talent tree for a playable class with specific specialization.
/// </summary>
public record TalentTree
{
    /// <summary>
    /// Gets the links related to the talent tree.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of the talent tree.
    /// </summary>
    [JsonPropertyName("id")]
    public long Id { get; init; }

    /// <summary>
    /// Gets a reference to the playable class associated with this talent tree.
    /// </summary>
    [JsonPropertyName("playable_class")]
    public PlayableClassReference PlayableClass { get; init; }

    /// <summary>
    /// Gets a reference to the playable specialization associated with this talent tree.
    /// </summary>
    [JsonPropertyName("playable_specialization")]
    public PlayableSpecializationReference PlayableSpecialization { get; init; }

    /// <summary>
    /// Gets the name of the talent tree.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets a reference to the media related to the talent tree.
    /// </summary>
    [JsonPropertyName("media")]
    public TalentTreeMediaReference Media { get; init; }

    /// <summary>
    /// Gets the restriction lines of the talent tree.
    /// </summary>
    [JsonPropertyName("restriction_lines")]
    public TalentTreeRestrictionLine[] RestrictionLines { get; init; }

    /// <summary>
    /// Gets the talent nodes associated with the class of the talent tree.
    /// </summary>
    [JsonPropertyName("class_talent_nodes")]
    public TalentNode[] ClassTalentNodes { get; init; }

    /// <summary>
    /// Gets the talent nodes associated with the class specialization of the talent tree.
    /// </summary>
    [JsonPropertyName("spec_talent_nodes")]
    public TalentNode[] SpecializationTalentNodes { get; init; }
}
