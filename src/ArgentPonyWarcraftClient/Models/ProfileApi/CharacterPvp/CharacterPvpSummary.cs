using System.Text.Json.Serialization;

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
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets links to the PvP brackets for the character.
        /// </summary>
        [JsonPropertyName("brackets")]
        public Self[] Brackets { get; set; }

        /// <summary>
        /// Gets the honor level of the character.
        /// </summary>
        [JsonPropertyName("honor_level")]
        public long HonorLevel { get; set; }

        /// <summary>
        /// Gets the PvP map statistics for the character.
        /// </summary>
        [JsonPropertyName("pvp_map_statistics")]
        public PvpMapStatistic[] PvpMapStatistics { get; set; }

        /// <summary>
        /// Gets the number of honorable kills for the character.
        /// </summary>
        [JsonPropertyName("honorable_kills")]
        public long HonorableKills { get; set; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonPropertyName("character")]
        public CharacterReference Character { get; set; }
    }
}
