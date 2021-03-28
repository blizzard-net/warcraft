using System.Text.Json.Serialization;

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
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the current Mythic Keystone period.
        /// </summary>
        [JsonPropertyName("current_period")]
        public CurrentPeriod CurrentPeriod { get; set; }

        /// <summary>
        /// Gets references to the Mythic Keystone season details for the character.
        /// </summary>
        [JsonPropertyName("seasons")]
        public CharacterMythicKeystoneSeasonDetailsReference[] Seasons { get; set; }

        /// <summary>
        /// Gets the character details.
        /// </summary>
        [JsonPropertyName("character")]
        public CharacterReference Character { get; set; }
    }
}
