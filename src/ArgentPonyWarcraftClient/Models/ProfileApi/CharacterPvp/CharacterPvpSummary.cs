using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A PvP summary for a character.
    /// </summary>
    public class CharacterPvpSummary
    {
        /// <summary>
        /// Gets the links for the PvP summary for the character.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets links to the PvP brackets for the character.
        /// </summary>
        [JsonProperty("brackets")]
        public Self[] Brackets { get; set; }

        /// <summary>
        /// Gets the honor level of the character.
        /// </summary>
        [JsonProperty("honor_level")]
        public long HonorLevel { get; set; }

        /// <summary>
        /// Gets the PvP map statistics for the character.
        /// </summary>
        [JsonProperty("pvp_map_statistics")]
        public PvpMapStatistic[] PvpMapStatistics { get; set; }

        /// <summary>
        /// Gets the number of honorable kills for the character.
        /// </summary>
        [JsonProperty("honorable_kills")]
        public long HonorableKills { get; set; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonProperty("character")]
        public CharacterReference Character { get; set; }
    }
}
