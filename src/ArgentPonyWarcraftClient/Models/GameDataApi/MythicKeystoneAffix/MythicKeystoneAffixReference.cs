using Newtonsoft.Json;

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
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the keystone affix.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the keystone affix.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
