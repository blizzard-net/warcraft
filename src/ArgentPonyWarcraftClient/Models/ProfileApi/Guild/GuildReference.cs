namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a guild.
/// </summary>
public record GuildReference
{
    /// <summary>
    /// Gets the key for the guild.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the guild.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the guild.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets a reference to the guild's realm.
    /// </summary>
    [JsonPropertyName("realm")]
    public RealmReference Realm { get; init; }

    /// <summary>
    /// Gets the faction of the guild (Alliance or Horde).
    /// </summary>
    [JsonPropertyName("faction")]
    public EnumType Faction { get; init; }
}
