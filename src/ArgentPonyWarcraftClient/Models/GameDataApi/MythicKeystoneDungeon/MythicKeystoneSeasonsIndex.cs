using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of mythic keystone seasons.
    /// </summary>
    public class MythicKeystoneSeasonsIndex
    {
        /// <summary>
        /// Gets links for the index of mythic keystone seasons.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the mythic keystone seasons.
        /// </summary>
        [JsonProperty("seasons")]
        public MythicKeystoneSeasonReference[] Seasons { get; set; }

        /// <summary>
        /// Gets a reference to the current mythic keystone seasons.
        /// </summary>
        [JsonProperty("current_season")]
        public MythicKeystoneSeasonReference CurrentSeason { get; set; }
    }
}
