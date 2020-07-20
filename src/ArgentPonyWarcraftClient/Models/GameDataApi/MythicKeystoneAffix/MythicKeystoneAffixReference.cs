using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a mythic keystone affix.
    /// </summary>
    public class MythicKeystoneAffixReference
    {
        /// <summary>
        /// Gets the key for the keystone affix.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the keystone affix.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the keystone affix.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
