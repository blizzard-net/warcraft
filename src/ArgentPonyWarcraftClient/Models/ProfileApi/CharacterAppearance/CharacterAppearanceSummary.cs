namespace ArgentPonyWarcraftClient;

/// <summary>
/// A summary of a character's appearance settings.
/// </summary>
public record CharacterAppearanceSummary
{
    /// <summary>
    /// Gets links for the character appearance summary.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a reference to the character.
    /// </summary>
    [JsonPropertyName("character")]
    public CharacterReference Character { get; init; }

    /// <summary>
    /// Gets a reference to the character's race.
    /// </summary>
    [JsonPropertyName("playable_race")]
    public PlayableRaceReference PlayableRace { get; init; }

    /// <summary>
    /// Gets a reference to the character's class.
    /// </summary>
    [JsonPropertyName("playable_class")]
    public PlayableClassReference PlayableClass { get; init; }

    /// <summary>
    /// Gets a reference to the character's active specialization.
    /// </summary>
    [JsonPropertyName("active_spec")]
    public PlayableSpecializationReference ActiveSpec { get; init; }

    /// <summary>
    /// Gets the character's gender.
    /// </summary>
    [JsonPropertyName("gender")]
    public EnumType Gender { get; init; }

    /// <summary>
    /// Gets the character's faction (Alliance or Horde).
    /// </summary>
    [JsonPropertyName("faction")]
    public EnumType Faction { get; init; }

    /// <summary>
    /// Gets the guild crest of the character's guild.
    /// </summary>
    [JsonPropertyName("guild_crest")]
    public GuildCrest GuildCrest { get; init; }

    /// <summary>
    /// Gets the settings related to the character's appearance.
    /// </summary>
    [JsonPropertyName("appearance")]
    public Appearance Appearance { get; init; }

    /// <summary>
    /// Gets the character's equipped items.
    /// </summary>
    [JsonPropertyName("items")]
    public EquippedItemAppearance[] Items { get; init; }
}
