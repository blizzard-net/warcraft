namespace ArgentPonyWarcraftClient;

/// <summary>
/// A guild roster.
/// </summary>
public record GuildRoster
{
    /// <summary>
    /// Gets links for the guild roster.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a reference to the guild.
    /// </summary>
    [JsonPropertyName("guild")]
    public GuildReference Guild { get; init; }

    /// <summary>
    /// Gets the guild members.
    /// </summary>
    [JsonPropertyName("members")]
    public GuildMember[] Members { get; init; }
}
