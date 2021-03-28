using System.Text.Json.Serialization;

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
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonPropertyName("character")]
        public CharacterReference Character { get; set; }

        /// <summary>
        /// Gets the faction.
        /// </summary>
        [JsonPropertyName("faction")]
        public EnumType Faction { get; set; }

        /// <summary>
        /// Gets the PvP bracket.
        /// </summary>
        [JsonPropertyName("bracket")]
        public Bracket Bracket { get; set; }

        /// <summary>
        /// Gets the character's rating in this PvP bracket.
        /// </summary>
        [JsonPropertyName("rating")]
        public int Rating { get; set; }

        /// <summary>
        /// Gets a reference to the PvP season.
        /// </summary>
        [JsonPropertyName("season")]
        public PvpSeasonReference Season { get; set; }

        /// <summary>
        /// Gets a reference to the PvP tier.
        /// </summary>
        [JsonPropertyName("tier")]
        public PvpTierReferenceWithoutName Tier { get; set; }

        /// <summary>
        /// Gets the PvP match statistics for the season.
        /// </summary>
        [JsonPropertyName("season_match_statistics")]
        public PvpMatchStatistics SeasonMatchStatistics { get; set; }

        /// <summary>
        /// Gets the PvP match statistics for the week.
        /// </summary>
        [JsonPropertyName("weekly_match_statistics")]
        public PvpMatchStatistics WeeklyMatchStatistics { get; set; }
    }
}
