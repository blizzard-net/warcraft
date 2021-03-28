using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A PvP summary for a character.
    /// </summary>
    public record CharacterPvpSummary
    {
        /// <summary>
        /// Gets the links for the PvP summary for the character.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets links to the PvP brackets for the character.
        /// </summary>
        [JsonPropertyName("brackets")]
        public Self[] Brackets { get; }

        /// <summary>
        /// Gets the honor level of the character.
        /// </summary>
        [JsonPropertyName("honor_level")]
        public int HonorLevel { get; }

        /// <summary>
        /// Gets the PvP map statistics for the character.
        /// </summary>
        [JsonPropertyName("pvp_map_statistics")]
        public PvpMapStatistic[] PvpMapStatistics { get; }

        /// <summary>
        /// Gets the number of honorable kills for the character.
        /// </summary>
        [JsonPropertyName("honorable_kills")]
        public int HonorableKills { get; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonPropertyName("character")]
        public CharacterReference Character { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterPvpSummary"/> class.
        /// </summary>
        /// <param name="links">The links for the PvP summary for the character.</param>
        /// <param name="brackets">Links to the PvP brackets for the character.</param>
        /// <param name="honorLevel">The honor level of the character.</param>
        /// <param name="pvpMapStatistics">The PvP map statistics for the character.</param>
        /// <param name="honorableKills">The number of honorable kills for the character.</param>
        /// <param name="character">A reference to the character.</param>
        [JsonConstructor]
        public CharacterPvpSummary(Links links, Self[] brackets, int honorLevel, PvpMapStatistic[] pvpMapStatistics, int honorableKills, CharacterReference character)
        {
            Links = links;
            Brackets = brackets;
            HonorLevel = honorLevel;
            PvpMapStatistics = pvpMapStatistics;
            HonorableKills = honorableKills;
            Character = character;
        }
    }
}
