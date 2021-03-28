using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of links to other documents related to Mythic Keystone dungeons.
    /// </summary>
    public record MythicKeystoneIndex
    {
        /// <summary>
        /// Gets links for the index of mythic keystone documents.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a link to mythic keystone seasons.
        /// </summary>
        [JsonPropertyName("seasons")]
        public Self Seasons { get; }

        /// <summary>
        /// Gets a link to mythic keystone dungeons.
        /// </summary>
        [JsonPropertyName("dungeons")]
        public Self Dungeons { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MythicKeystoneIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of mythic keystone documents.</param>
        /// <param name="seasons">A link to mythic keystone seasons.</param>
        /// <param name="dungeons">A link to mythic keystone dungeons.</param>
        [JsonConstructor]
        public MythicKeystoneIndex(Links links, Self seasons, Self dungeons)
        {
            Links = links;
            Seasons = seasons;
            Dungeons = dungeons;
        }
    }
}
