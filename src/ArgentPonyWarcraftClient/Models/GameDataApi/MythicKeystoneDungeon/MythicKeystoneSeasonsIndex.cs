namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of mythic keystone seasons.
/// </summary>
public record MythicKeystoneSeasonsIndex
{
    /// <summary>
    /// Gets links for the index of mythic keystone seasons.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets references to the mythic keystone seasons.
    /// </summary>
    [JsonPropertyName("seasons")]
    public MythicKeystoneSeasonReference[] Seasons { get; init; }

    /// <summary>
    /// Gets a reference to the current mythic keystone season.
    /// </summary>
    [JsonPropertyName("current_season")]
    public MythicKeystoneSeasonReference CurrentSeason { get; init; }
}
