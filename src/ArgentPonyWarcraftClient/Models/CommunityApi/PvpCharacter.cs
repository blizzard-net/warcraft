using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.Community
{
    /// <summary>
    /// A PvP character
    /// </summary>
    public class PvpCharacter
    {
        /// <summary>
        /// Gets or sets the ranking.
        /// </summary>
        [JsonProperty("ranking")]
        public int Ranking { get; set; }

        /// <summary>
        /// Gets or sets the rating.
        /// </summary>
        [JsonProperty("rating")]
        public int Rating { get; set; }

        /// <summary>
        /// Gets or sets the character's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the realm ID.
        /// </summary>
        [JsonProperty("realmId")]
        public int RealmId { get; set; }

        /// <summary>
        /// Gets or sets the realm name.
        /// </summary>
        [JsonProperty("realmName")]
        public string RealmName { get; set; }

        /// <summary>
        /// Gets or sets the realm slug.
        /// </summary>
        [JsonProperty("realmSlug")]
        public string RealmSlug { get; set; }

        /// <summary>
        /// Gets or sets the race.
        /// </summary>
        [JsonProperty("raceId")]
        public Race Race { get; set; }

        /// <summary>
        /// Gets or sets the class.
        /// </summary>
        [JsonProperty("classId")]
        public CharacterClass Class { get; set; }

        /// <summary>
        /// Gets or sets the spec ID.
        /// </summary>
        [JsonProperty("specId")]
        public int SpecId { get; set; }

        /// <summary>
        /// Gets or sets the faction.
        /// </summary>
        [JsonProperty("factionId")]
        public Faction Faction { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        [JsonProperty("genderId")]
        public Gender GenderId { get; set; }

        /// <summary>
        /// Gets or sets the number of wins in the season.
        /// </summary>
        [JsonProperty("seasonWins")]
        public int SeasonWins { get; set; }

        /// <summary>
        /// Gets or sets the number of losses in the season.
        /// </summary>
        [JsonProperty("seasonLosses")]
        public int SeasonLosses { get; set; }

        /// <summary>
        /// Gets or sets the number of wins in the week.
        /// </summary>
        [JsonProperty("weeklyWins")]
        public int WeeklyWins { get; set; }

        /// <summary>
        /// Gets or sets the number of losses in the week.
        /// </summary>
        [JsonProperty("weeklyLosses")]
        public int WeeklyLosses { get; set; }

        /// <summary>
        /// Gets or sets the character's PVP tier.
        /// </summary>
        [JsonProperty("tier")]
        public string Tier { get; set; }
    }
}
