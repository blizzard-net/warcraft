using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An entry in a PvP leaderboard.
    /// </summary>
    public class PvpLeaderboardEntry
    {
        /// <summary>
        /// Gets the profile of the character.
        /// </summary>
        [JsonProperty("character")]
        public Profile Character { get; set; }

        /// <summary>
        /// Gets the character's faction (Alliance or Horde).
        /// </summary>
        [JsonProperty("faction")]
        public EnumTypeWithoutName Faction { get; set; }

        /// <summary>
        /// Gets the character's rank on this PvP leaderboard.
        /// </summary>
        [JsonProperty("rank")]
        public long Rank { get; set; }

        /// <summary>
        /// Gets the character's rating on this PvP leaderboard.
        /// </summary>
        [JsonProperty("rating")]
        public long Rating { get; set; }

        /// <summary>
        /// Gets the season match statistics for the character.
        /// </summary>
        [JsonProperty("season_match_statistics")]
        public SeasonMatchStatistics SeasonMatchStatistics { get; set; }

        /// <summary>
        /// Gets a reference to the character's PvP tier.
        /// </summary>
        [JsonProperty("tier")]
        public PvpTierReference Tier { get; set; }
    }
}
