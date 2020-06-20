using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to the Mythic Keystone season details for a character.
    /// </summary>
    public class CharacterMythicKeystoneSeasonDetailsReference
    {
        /// <summary>
        /// Gets the key for the Mythic Keystone season details for a character.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the ID of the Mythic Keystone season details for a character.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
