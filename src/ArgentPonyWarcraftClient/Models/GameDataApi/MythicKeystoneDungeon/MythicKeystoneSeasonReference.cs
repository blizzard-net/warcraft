using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a Mythic Keystone season.
    /// </summary>
    public class MythicKeystoneSeasonReference
    {
        /// <summary>
        /// Gets the key for the Mythic Keystone season.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the ID of the Mythic Keystone season.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
