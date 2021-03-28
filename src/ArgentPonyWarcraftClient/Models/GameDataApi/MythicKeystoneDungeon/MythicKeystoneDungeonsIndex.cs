using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of mythic keystone dungeons.
    /// </summary>
    public record MythicKeystoneDungeonsIndex
    {
        /// <summary>
        /// Gets links for the index of mythic keystone dungeons.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to the mythic keystone dungeons.
        /// </summary>
        [JsonPropertyName("dungeons")]
        public MythicKeystoneDungeonReference[] Dungeons { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MythicKeystoneDungeonsIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of mythic keystone dungeons.</param>
        /// <param name="dungeons">References to the mythic keystone dungeons.</param>
        [JsonConstructor]
        public MythicKeystoneDungeonsIndex(Links links, MythicKeystoneDungeonReference[] dungeons)
        {
            Links = links;
            Dungeons = dungeons;
        }
    }
}
