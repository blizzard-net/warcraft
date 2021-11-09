namespace ArgentPonyWarcraftClient;

/// <summary>
/// A character summary for a guild member.
/// </summary>
public record GuildCharacter
{
    /// <summary>
    /// Gets a link to the character's profile.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

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
    /// Gets the level of the character.
    /// </summary>
    [JsonPropertyName("level")]
    public int Level { get; init; }

    /// <summary>
    /// Gets a reference to the character's class.
    /// </summary>
    [JsonPropertyName("playable_class")]
    public PlayableClassReferenceWithoutName PlayableClass { get; init; }

    /// <summary>
    /// Gets a reference to the character's race.
    /// </summary>
    [JsonPropertyName("playable_race")]
    public PlayableRaceReferenceWithoutName PlayableRace { get; init; }
}
