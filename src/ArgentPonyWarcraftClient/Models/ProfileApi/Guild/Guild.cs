namespace ArgentPonyWarcraftClient;

/// <summary>
/// A guild.
/// </summary>
public record Guild
{
    /// <summary>
    /// Gets links for the guild.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of the guild.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the name of the guild.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the guild's faction (Alliance or Horde).
    /// </summary>
    [JsonPropertyName("faction")]
    public EnumType Faction { get; init; }

    /// <summary>
    /// Gets the guild achievement points.
    /// </summary>
    [JsonPropertyName("achievement_points")]
    public int AchievementPoints { get; init; }

    /// <summary>
    /// Gets the number of members in the guild.
    /// </summary>
    [JsonPropertyName("member_count")]
    public int MemberCount { get; init; }

    /// <summary>
    /// Gets a reference to the guild's realm.
    /// </summary>
    [JsonPropertyName("realm")]
    public RealmReference Realm { get; init; }

    /// <summary>
    /// Gets the guild crest.
    /// </summary>
    [JsonPropertyName("crest")]
    public GuildCrest Crest { get; init; }

    /// <summary>
    /// Gets a link to the guild roster.
    /// </summary>
    [JsonPropertyName("roster")]
    public Self Roster { get; init; }

    /// <summary>
    /// Gets a link to the guild achievements.
    /// </summary>
    [JsonPropertyName("achievements")]
    public Self Achievements { get; init; }

    /// <summary>
    /// Gets the timestamp when the guild was created.
    /// </summary>
    [JsonPropertyName("created_timestamp")]
    public DateTimeOffset CreatedTimestamp { get; init; }

    /// <summary>
    /// Gets a link to the guild activity.
    /// </summary>
    [JsonPropertyName("activity")]
    public Self Activity { get; init; }
}
