using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Mythic keystone affix media.
    /// </summary>
    public class MythicKeystoneAffixMedia
    {
        /// <summary>
        /// Gets links for the mythic keystone affix media.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; private set; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonProperty("assets")]
        public Asset[] Assets { get; private set; }

        /// <summary>
        /// Gets the ID of the mythic keystone affix.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
