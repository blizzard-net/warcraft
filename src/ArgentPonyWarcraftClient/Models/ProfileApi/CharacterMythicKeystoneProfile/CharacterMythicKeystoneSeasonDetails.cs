using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a reference to the Mythic Keystone season.
        /// </summary>
        [JsonProperty("season")]
        public MythicKeystoneSeasonReference Season { get; set; }

        /// <summary>
        /// Gets the best runs for this character during this season.
        /// </summary>
        [JsonProperty("best_runs")]
        public MythicKeystoneRun[] BestRuns { get; set; }

        /// <summary>
        /// Gets the character details.
        /// </summary>
        [JsonProperty("character")]
        public MythicKeystoneProfileCharacter Character { get; set; }
    }
}
