namespace ArgentPonyWarcraftClient;

/// <summary>
/// A playable race.
/// </summary>
public record PlayableRace
{
    /// <summary>
    /// Gets links for the playable race.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of the playable race.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the name of the playable race.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the gender-specific names for the playable race.
    /// </summary>
    [JsonPropertyName("gender_name")]
    public GenderName GenderName { get; init; }

    /// <summary>
    /// Gets the faction of the playable race (Alliance or Horde).
    /// </summary>
    [JsonPropertyName("faction")]
    public EnumType Faction { get; init; }

    /// <summary>
    /// Gets a value indicating whether the playable race can be selected.
    /// </summary>
    [JsonPropertyName("is_selectable")]
    public bool IsSelectable { get; init; }

    /// <summary>
    /// Gets a value indicating whether the race is allied to a faction.
    /// </summary>
    [JsonPropertyName("is_allied_race")]
    public bool IsAlliedRace { get; init; }

    /// <summary>
    /// Gets references to the playable classes that are compatible with this playable race.
    /// </summary>
    [JsonPropertyName("playable_classes")]
    public PlayableClassReference[] PlayableClasses { get; init; }
}
