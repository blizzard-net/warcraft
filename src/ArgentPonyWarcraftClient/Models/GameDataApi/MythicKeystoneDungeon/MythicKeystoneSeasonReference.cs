using Newtonsoft.Json;

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
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the ID of the Mythic Keystone season.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
