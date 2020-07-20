using System.Text.Json.Serialization;

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
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the ID of the Mythic Keystone period.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
