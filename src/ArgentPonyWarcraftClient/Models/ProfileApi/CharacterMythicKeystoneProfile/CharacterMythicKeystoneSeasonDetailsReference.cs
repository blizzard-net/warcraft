using System.Text.Json.Serialization;

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
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the ID of the Mythic Keystone season details for a character.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
