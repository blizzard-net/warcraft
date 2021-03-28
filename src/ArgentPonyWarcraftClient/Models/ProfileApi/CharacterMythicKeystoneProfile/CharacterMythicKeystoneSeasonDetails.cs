using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Mythic Keystone season details for a character.
    /// </summary>
    public class CharacterMythicKeystoneSeasonDetails
    {
        /// <summary>
        /// Gets links for the Mythic Keystone season details.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a reference to the Mythic Keystone season.
        /// </summary>
        [JsonPropertyName("season")]
        public MythicKeystoneSeasonReference Season { get; set; }

        /// <summary>
        /// Gets the best runs for this character during this season.
        /// </summary>
        [JsonPropertyName("best_runs")]
        public MythicKeystoneRun[] BestRuns { get; set; }

        /// <summary>
        /// Gets the character details.
        /// </summary>
        [JsonPropertyName("character")]
        public CharacterReference Character { get; set; }
    }
}
