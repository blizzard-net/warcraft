using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// PvP bracket statistics for a character.
    /// </summary>
    public record CharacterPvpBracketStatistics
    {
        /// <summary>
        /// Gets links for the PvP bracket statistics for the character.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonPropertyName("character")]
        public CharacterReference Character { get; }

        /// <summary>
        /// Gets the faction.
        /// </summary>
        [JsonPropertyName("faction")]
        public EnumType Faction { get; }

        /// <summary>
        /// Gets the PvP bracket.
        /// </summary>
        [JsonPropertyName("bracket")]
        public Bracket Bracket { get; }

        /// <summary>
        /// Gets the character's rating in this PvP bracket.
        /// </summary>
        [JsonPropertyName("rating")]
        public int Rating { get; }

        /// <summary>
        /// Gets a reference to the PvP season.
        /// </summary>
        [JsonPropertyName("season")]
        public PvpSeasonReference Season { get; }

        /// <summary>
        /// Gets a reference to the PvP tier.
        /// </summary>
        [JsonPropertyName("tier")]
        public PvpTierReferenceWithoutName Tier { get; }

        /// <summary>
        /// Gets the PvP match statistics for the season.
        /// </summary>
        [JsonPropertyName("season_match_statistics")]
        public PvpMatchStatistics SeasonMatchStatistics { get; }

        /// <summary>
        /// Gets the PvP match statistics for the week.
        /// </summary>
        [JsonPropertyName("weekly_match_statistics")]
        public PvpMatchStatistics WeeklyMatchStatistics { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterPvpBracketStatistics"/> class.
        /// </summary>
        /// <param name="links">Links for the PvP bracket statistics for the character.</param>
        /// <param name="character">A reference to the character.</param>
        /// <param name="faction">The faction.</param>
        /// <param name="bracket">The PvP bracket.</param>
        /// <param name="rating">The character's rating in this PvP bracket.</param>
        /// <param name="season">A reference to the PvP season.</param>
        /// <param name="tier">A reference to the PvP tier.</param>
        /// <param name="seasonMatchStatistics">The PvP match statistics for the season.</param>
        /// <param name="weeklyMatchStatistics">The PvP match statistics for the week.</param>
        [JsonConstructor]
        public CharacterPvpBracketStatistics(Links links, CharacterReference character, EnumType faction, Bracket bracket, int rating, PvpSeasonReference season, PvpTierReferenceWithoutName tier, PvpMatchStatistics seasonMatchStatistics, PvpMatchStatistics weeklyMatchStatistics)
        {
            Links = links;
            Character = character;
            Faction = faction;
            Bracket = bracket;
            Rating = rating;
            Season = season;
            Tier = tier;
            SeasonMatchStatistics = seasonMatchStatistics;
            WeeklyMatchStatistics = weeklyMatchStatistics;
        }
    }
}
