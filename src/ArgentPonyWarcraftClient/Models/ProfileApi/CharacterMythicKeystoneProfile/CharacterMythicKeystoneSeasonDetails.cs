using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Mythic Keystone season details for a character.
    /// </summary>
    public record CharacterMythicKeystoneSeasonDetails
    {
        /// <summary>
        /// Gets links for the Mythic Keystone season details.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a reference to the Mythic Keystone season.
        /// </summary>
        [JsonPropertyName("season")]
        public MythicKeystoneSeasonReference Season { get; }

        /// <summary>
        /// Gets the best runs for this character during this season.
        /// </summary>
        [JsonPropertyName("best_runs")]
        public MythicKeystoneRun[] BestRuns { get; }

        /// <summary>
        /// Gets the character details.
        /// </summary>
        [JsonPropertyName("character")]
        public CharacterReference Character { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterMythicKeystoneSeasonDetails"/> class.
        /// </summary>
        /// <param name="links">Links for the Mythic Keystone season details.</param>
        /// <param name="season">A reference to the Mythic Keystone season.</param>
        /// <param name="bestRuns">The best runs for this character during this season.</param>
        /// <param name="character">The character details.</param>
        [JsonConstructor]
        public CharacterMythicKeystoneSeasonDetails(Links links, MythicKeystoneSeasonReference season, MythicKeystoneRun[] bestRuns, CharacterReference character)
        {
            Links = links;
            Season = season;
            BestRuns = bestRuns;
            Character = character;
        }
    }
}
