using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An entry in a PvP leaderboard.
    /// </summary>
    public record PvpLeaderboardEntry
    {
        /// <summary>
        /// Gets the profile of the character.
        /// </summary>
        [JsonPropertyName("character")]
        public Profile Character { get; }

        /// <summary>
        /// Gets the character's faction (Alliance or Horde).
        /// </summary>
        [JsonPropertyName("faction")]
        public EnumTypeWithoutName Faction { get; }

        /// <summary>
        /// Gets the character's rank on this PvP leaderboard.
        /// </summary>
        [JsonPropertyName("rank")]
        public int Rank { get; }

        /// <summary>
        /// Gets the character's rating on this PvP leaderboard.
        /// </summary>
        [JsonPropertyName("rating")]
        public int Rating { get; }

        /// <summary>
        /// Gets the season match statistics for the character.
        /// </summary>
        [JsonPropertyName("season_match_statistics")]
        public SeasonMatchStatistics SeasonMatchStatistics { get; }

        /// <summary>
        /// Gets a reference to the character's PvP tier.
        /// </summary>
        [JsonPropertyName("tier")]
        public PvpTierReferenceWithoutName Tier { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PvpLeaderboardEntry"/> class.
        /// </summary>
        /// <param name="character">The profile of the character.</param>
        /// <param name="faction">The character's faction (Alliance or Horde).</param>
        /// <param name="rank">The character's rank on this PvP leaderboard.</param>
        /// <param name="rating">The character's rating on this PvP leaderboard.</param>
        /// <param name="seasonMatchStatistics">The season match statistics for the character.</param>
        /// <param name="tier">A reference to the character's PvP tier.</param>
        [JsonConstructor]
        public PvpLeaderboardEntry(Profile character, EnumTypeWithoutName faction, int rank, int rating, SeasonMatchStatistics seasonMatchStatistics, PvpTierReferenceWithoutName tier)
        {
            Character = character;
            Faction = faction;
            Rank = rank;
            Rating = rating;
            SeasonMatchStatistics = seasonMatchStatistics;
            Tier = tier;
        }
    }
}
