using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a Mythic Keystone period.
    /// </summary>
    public class MythicKeystonePeriodReference
    {
        /// <summary>
        /// Gets the key for the Mythic Keystone period.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the ID of the Mythic Keystone period.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
