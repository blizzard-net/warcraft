using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// PvP bracket statistics for a character.
    /// </summary>
    public class CharacterPvpBracketStatistics
    {
        /// <summary>
        /// Gets links for the PvP bracket statistics for the character.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonProperty("character")]
        public CharacterReference Character { get; set; }

        /// <summary>
        /// Gets the faction.
        /// </summary>
        [JsonProperty("faction")]
        public EnumType Faction { get; set; }

        /// <summary>
        /// Gets the PvP bracket.
        /// </summary>
        [JsonProperty("bracket")]
        public Bracket Bracket { get; set; }

        /// <summary>
        /// Gets the character's rating in this PvP bracket.
        /// </summary>
        [JsonProperty("rating")]
        public long Rating { get; set; }

        /// <summary>
        /// Gets a reference to the PvP season.
        /// </summary>
        [JsonProperty("season")]
        public PvpSeasonReference Season { get; set; }

        /// <summary>
        /// Gets a reference to the PvP tier.
        /// </summary>
        [JsonProperty("tier")]
        public PvpTierReferenceWithoutName Tier { get; set; }

        /// <summary>
        /// Gets the PvP match statistics for the season.
        /// </summary>
        [JsonProperty("season_match_statistics")]
        public PvpMatchStatistics SeasonMatchStatistics { get; set; }

        /// <summary>
        /// Gets the PvP match statistics for the week.
        /// </summary>
        [JsonProperty("weekly_match_statistics")]
        public PvpMatchStatistics WeeklyMatchStatistics { get; set; }
    }
}
