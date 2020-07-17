using System.Text.Json.Serialization;

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
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a link to mythic keystone seasons.
        /// </summary>
        [JsonPropertyName("seasons")]
        public Self Seasons { get; set; }

        /// <summary>
        /// Gets a link to mythic keystone dungeons.
        /// </summary>
        [JsonPropertyName("dungeons")]
        public Self Dungeons { get; set; }
    }
}
