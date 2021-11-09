namespace ArgentPonyWarcraftClient;

/// <summary>
/// A World of Warcraft player character.
/// </summary>
public record CharacterProfileSummary
{
    /// <summary>
    /// Gets links for the character.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of the character.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the name of the character.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the gender of the character.
    /// </summary>
    [JsonPropertyName("gender")]
    public EnumType Gender { get; init; }

    /// <summary>
    /// Gets the faction of the character (Alliance or Horde).
    /// </summary>
    [JsonPropertyName("faction")]
    public EnumType Faction { get; init; }

    /// <summary>
    /// Gets the race of the character.
    /// </summary>
    [JsonPropertyName("race")]
    public PlayableRaceReference Race { get; init; }

    /// <summary>
    /// Gets the class of the character.
    /// </summary>
    [JsonPropertyName("character_class")]
    public PlayableClassReference CharacterClass { get; init; }

    /// <summary>
    /// Gets the active spec for the character.
    /// </summary>
    [JsonPropertyName("active_spec")]
    public PlayableSpecializationReference ActiveSpec { get; init; }

    /// <summary>
    /// Gets a reference to the character's realm.
    /// </summary>
    [JsonPropertyName("realm")]
    public RealmReference Realm { get; init; }

    /// <summary>
    /// Gets a reference to the character's guild.
    /// </summary>
    [JsonPropertyName("guild")]
    public GuildReference Guild { get; init; }

    /// <summary>
    /// Gets the level of the character.
    /// </summary>
    [JsonPropertyName("level")]
    public int Level { get; init; }

    /// <summary>
    /// Gets the character's experience points.
    /// </summary>
    [JsonPropertyName("experience")]
    public int Experience { get; init; }

    /// <summary>
    /// Gets the number of achievement points the character has earned.
    /// </summary>
    [JsonPropertyName("achievement_points")]
    public int AchievementPoints { get; init; }

    /// <summary>
    /// Gets a link to the character's achievements.
    /// </summary>
    [JsonPropertyName("achievements")]
    public Self Achievements { get; init; }

    /// <summary>
    /// Gets a link to the character's titles.
    /// </summary>
    [JsonPropertyName("titles")]
    public Self Titles { get; init; }

    /// <summary>
    /// Gets a link to the character's PVP summary.
    /// </summary>
    [JsonPropertyName("pvp_summary")]
    public Self PvpSummary { get; init; }

    /// <summary>
    /// Gets a link to the character's encounters.
    /// </summary>
    [JsonPropertyName("encounters")]
    public Self Encounters { get; init; }

    /// <summary>
    /// Gets a link to the media for this character.
    /// </summary>
    [JsonPropertyName("media")]
    public Self Media { get; init; }

    /// <summary>
    /// Gets the last login timestamp for the character.
    /// </summary>
    [JsonPropertyName("last_login_timestamp")]
    public DateTimeOffset LastLoginTimestamp { get; init; }

    /// <summary>
    /// Gets the character's average item level.
    /// </summary>
    [JsonPropertyName("average_item_level")]
    public int AverageItemLevel { get; init; }

    /// <summary>
    /// Gets the character's equipped item level.
    /// </summary>
    [JsonPropertyName("equipped_item_level")]
    public int EquippedItemLevel { get; init; }

    /// <summary>
    /// Gets a link to the character's specializations.
    /// </summary>
    [JsonPropertyName("specializations")]
    public Self Specializations { get; init; }

    /// <summary>
    /// Gets a link to the character's statistics.
    /// </summary>
    [JsonPropertyName("statistics")]
    public Self Statistics { get; init; }

    /// <summary>
    /// Gets a link to the character's mythic keystone profile.
    /// </summary>
    [JsonPropertyName("mythic_keystone_profile")]
    public Self MythicKeystoneProfile { get; init; }

    /// <summary>
    /// Gets a link to the character's equipment.
    /// </summary>
    [JsonPropertyName("equipment")]
    public Self Equipment { get; init; }

    /// <summary>
    /// Gets a link to the character's appearance.
    /// </summary>
    [JsonPropertyName("appearance")]
    public Self Appearance { get; init; }

    /// <summary>
    /// Gets a link to the character's collections.
    /// </summary>
    [JsonPropertyName("collections")]
    public Self Collections { get; init; }

    /// <summary>
    /// Gets a reference to the active title for the character.
    /// </summary>
    [JsonPropertyName("active_title")]
    public TitleReferenceWithDisplayString ActiveTitle { get; init; }

    /// <summary>
    /// Gets a link to the character's reputations.
    /// </summary>
    [JsonPropertyName("reputations")]
    public Self Reputations { get; init; }

    /// <summary>
    /// Gets a link to the character's quests.
    /// </summary>
    [JsonPropertyName("quests")]
    public Self Quests { get; init; }

    /// <summary>
    /// Gets a link to the character's achievement statistics.
    /// </summary>
    [JsonPropertyName("achievements_statistics")]
    public Self AchievementsStatistics { get; init; }

    /// <summary>
    /// Gets a link to the character's professions.
    /// </summary>
    [JsonPropertyName("professions")]
    public Self Professions { get; init; }

    /// <summary>
    /// Gets the covenant progress for the character.
    /// </summary>
    [JsonPropertyName("covenant_progress")]
    public CovenantProgress CovenantProgress { get; init; }
}
