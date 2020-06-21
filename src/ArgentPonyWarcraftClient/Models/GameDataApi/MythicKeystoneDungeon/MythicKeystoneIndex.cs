using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of links to other documents related to Mythic Keystone dungeons.
    /// </summary>
    public class MythicKeystoneIndex
    {
        /// <summary>
        /// Gets links for the index of mythic keystone documents.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a link to mythic keystone seasons.
        /// </summary>
        [JsonProperty("seasons")]
        public Self Seasons { get; set; }

        /// <summary>
        /// Gets a link to mythic keystone dungeons.
        /// </summary>
        [JsonProperty("dungeons")]
        public Self Dungeons { get; set; }
    }
}
