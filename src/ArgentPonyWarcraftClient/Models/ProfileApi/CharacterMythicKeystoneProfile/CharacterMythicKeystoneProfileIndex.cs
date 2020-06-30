using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// The Mythic Keystone profile index for a character.
    /// </summary>
    public class CharacterMythicKeystoneProfileIndex
    {
        /// <summary>
        /// Gets links for the Mythic Keystone profile index.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the current Mythic Keystone period.
        /// </summary>
        [JsonProperty("current_period")]
        public CurrentPeriod CurrentPeriod { get; set; }

        /// <summary>
        /// Gets references to the Mythic Keystone season details for the character.
        /// </summary>
        [JsonProperty("seasons")]
        public CharacterMythicKeystoneSeasonDetailsReference[] Seasons { get; set; }

        /// <summary>
        /// Gets the character details.
        /// </summary>
        [JsonProperty("character")]
        public CharacterReference Character { get; set; }
    }
}
