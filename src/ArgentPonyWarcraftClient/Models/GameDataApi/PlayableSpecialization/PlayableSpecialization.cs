namespace ArgentPonyWarcraftClient;

/// <summary>
/// A playable specialization.
/// </summary>
public record PlayableSpecialization
{
    /// <summary>
    /// Gets links for the playable specialization.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of the playable specialization.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets a reference to the playable class associated with this specialization.
    /// </summary>
    [JsonPropertyName("playable_class")]
    public PlayableClassReference PlayableClass { get; init; }

    /// <summary>
    /// Gets the name of the playable specialization.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the gender-specific descriptions for the playable specialization.
    /// </summary>
    [JsonPropertyName("gender_description")]
    public GenderDescription GenderDescription { get; init; }

    /// <summary>
    /// Get the media associated with the playable specialization.
    /// </summary>
    [JsonPropertyName("media")]
    public Media Media { get; init; }

    /// <summary>
    /// Gets the role associated with the playable specialization.
    /// </summary>
    [JsonPropertyName("role")]
    public EnumType Role { get; init; }

    /// <summary>
    /// Gets the talent tiers for the playable specialization.
    /// </summary>
    [JsonPropertyName("talent_tiers")]
    public TalentTier[] TalentTiers { get; init; }

    /// <summary>
    /// Gets the PvP talents for the playable specialization.
    /// </summary>
    [JsonPropertyName("pvp_talents")]
    public PvpTalentElement[] PvpTalents { get; init; }

    /// <summary>
    /// Gets a reference to the talent tree associated with this specialization.
    /// </summary>
    [JsonPropertyName("spec_talent_tree")]
    public TalentTreeReference SpecTalentTree { get; init; }

    /// <summary>
    /// Gets the <see cref="PowerType"/> for the playable specialization.
    /// </summary>
    [JsonPropertyName("power_type")]
    public PowerTypeReference PowerType { get; init; }

    /// <summary>
    /// Gets the primary stat type (intellect, agility, etc) for a playable specialization.
    /// </summary>
    [JsonPropertyName("primary_stat_type")]
    public EnumType PrimaryStatType { get; init; }
}
