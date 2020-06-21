using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of mythic keystone affixes.
    /// </summary>
    public class MythicKeystoneAffixesIndex
    {
        /// <summary>
        /// Gets links for the index of mythic keystone affixes.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the mythic keystone affixes.
        /// </summary>
        [JsonProperty("affixes")]
        public MythicKeystoneAffixReference[] Affixes { get; set; }
    }
}
