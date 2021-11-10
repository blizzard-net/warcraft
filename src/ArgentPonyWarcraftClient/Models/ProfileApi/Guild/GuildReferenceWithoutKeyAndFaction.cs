namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a guild.
/// </summary>
public record GuildReferenceWithoutKeyAndFaction
{
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
    /// Gets a reference to the realm to which the guild belongs.
    /// </summary>
    [JsonPropertyName("realm")]
    public RealmReferenceWithoutKey Realm { get; init; }
}
