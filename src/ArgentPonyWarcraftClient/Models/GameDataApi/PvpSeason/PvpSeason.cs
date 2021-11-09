namespace ArgentPonyWarcraftClient;

/// <summary>
/// A PvP season.
/// </summary>
public record PvpSeason
{
    /// <summary>
    /// Gets links for the PvP season.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of the PvP season.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets a link to PvP leaderboards.
    /// </summary>
    [JsonPropertyName("leaderboards")]
    public Self Leaderboards { get; init; }

    /// <summary>
    /// Gets a link to PvP rewards.
    /// </summary>
    [JsonPropertyName("rewards")]
    public Self Rewards { get; init; }

    /// <summary>
    /// Gets the start timestamp of the PvP season.
    /// </summary>
    [JsonPropertyName("season_start_timestamp")]
    public DateTimeOffset SeasonStartTimestamp { get; init; }

    /// <summary>
    /// Gets the end timestamp of the PvP season.
    /// </summary>
    [JsonPropertyName("season_end_timestamp")]
    public DateTimeOffset SeasonEndTimestamp { get; init; }
}
