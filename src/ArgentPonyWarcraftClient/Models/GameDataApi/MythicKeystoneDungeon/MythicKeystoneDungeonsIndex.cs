using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of mythic keystone dungeons.
    /// </summary>
    public class MythicKeystoneDungeonsIndex
    {
        /// <summary>
        /// Gets links for the index of mythic keystone dungeons.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the mythic keystone dungeons.
        /// </summary>
        [JsonProperty("dungeons")]
        public MythicKeystoneDungeonReference[] Dungeons { get; set; }
    }
}
