using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A mythic keystone affix.
    /// </summary>
    public class MythicKeystoneAffix
    {
        /// <summary>
        /// Gets links for the mythic keystone affix.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the mythic keystone affix.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the mythic keystone affix.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the description of the mythic keystone affix.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets the media for this mythic keystone affix.
        /// </summary>
        [JsonProperty("media")]
        public Media Media { get; set; }
    }
}
