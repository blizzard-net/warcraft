namespace ArgentPonyWarcraftClient;

/// <summary>
/// A character associated with a World of Warcraft account.
/// </summary>
public record AccountCharacter
{
    /// <summary>
    /// Gets a link to the character.
    /// </summary>
    [JsonPropertyName("character")]
    public Self Character { get; init; }

    /// <summary>
    /// Gets a link to the protected character information.
    /// </summary>
    [JsonPropertyName("protected_character")]
    public Self ProtectedCharacter { get; init; }

    /// <summary>
    /// Gets the name of the character.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the character.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets a reference to the character's realm.
    /// </summary>
    [JsonPropertyName("realm")]
    public RealmReference Realm { get; init; }

    /// <summary>
    /// Gets a reference to the character's class.
    /// </summary>
    [JsonPropertyName("playable_class")]
    public PlayableClassReference PlayableClass { get; init; }

    /// <summary>
    /// Gets a reference to the character's race.
    /// </summary>
    [JsonPropertyName("playable_race")]
    public PlayableClassReference PlayableRace { get; init; }

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
    /// Gets the level of the character.
    /// </summary>
    [JsonPropertyName("level")]
    public int Level { get; init; }
}
