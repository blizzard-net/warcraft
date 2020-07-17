using System.Text.Json.Serialization;

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
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the mythic keystone affix.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the mythic keystone affix.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the description of the mythic keystone affix.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets the media for this mythic keystone affix.
        /// </summary>
        [JsonPropertyName("media")]
        public Media Media { get; set; }
    }
}
