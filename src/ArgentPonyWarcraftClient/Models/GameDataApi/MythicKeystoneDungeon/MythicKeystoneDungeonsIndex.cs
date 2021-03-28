using System.Text.Json.Serialization;

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
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the mythic keystone dungeons.
        /// </summary>
        [JsonPropertyName("dungeons")]
        public MythicKeystoneDungeonReference[] Dungeons { get; set; }
    }
}
