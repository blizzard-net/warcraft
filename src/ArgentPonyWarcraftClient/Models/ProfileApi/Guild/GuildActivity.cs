namespace ArgentPonyWarcraftClient;

/// <summary>
/// A guild's activity.
/// </summary>
public record GuildActivity
{
    /// <summary>
    /// Gets links for the guild's activity.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a reference to the guild.
    /// </summary>
    [JsonPropertyName("guild")]
    public GuildReference Guild { get; init; }
}
