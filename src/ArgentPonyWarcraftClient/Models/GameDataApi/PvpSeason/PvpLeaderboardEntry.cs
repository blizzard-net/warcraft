namespace ArgentPonyWarcraftClient;

/// <summary>
/// An entry in a PvP leaderboard.
/// </summary>
public record PvpLeaderboardEntry
{
    /// <summary>
    /// Gets the profile of the character.
    /// </summary>
    [JsonPropertyName("character")]
    public Profile Character { get; init; }

    /// <summary>
    /// Gets the character's faction (Alliance or Horde).
    /// </summary>
    [JsonPropertyName("faction")]
    public EnumTypeWithoutName Faction { get; init; }

    /// <summary>
    /// Gets the character's rank on this PvP leaderboard.
    /// </summary>
    [JsonPropertyName("rank")]
    public int Rank { get; init; }

    /// <summary>
    /// Gets the character's rating on this PvP leaderboard.
    /// </summary>
    [JsonPropertyName("rating")]
    public int Rating { get; init; }

    /// <summary>
    /// Gets the season match statistics for the character.
    /// </summary>
    [JsonPropertyName("season_match_statistics")]
    public SeasonMatchStatistics SeasonMatchStatistics { get; init; }

    /// <summary>
    /// Gets a reference to the character's PvP tier.
    /// </summary>
    [JsonPropertyName("tier")]
    public PvpTierReferenceWithoutName Tier { get; init; }
}
