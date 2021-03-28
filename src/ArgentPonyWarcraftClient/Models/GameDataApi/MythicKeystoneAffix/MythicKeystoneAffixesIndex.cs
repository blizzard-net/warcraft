using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of mythic keystone affixes.
    /// </summary>
    public record MythicKeystoneAffixesIndex
    {
        /// <summary>
        /// Gets links for the index of mythic keystone affixes.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to the mythic keystone affixes.
        /// </summary>
        [JsonPropertyName("affixes")]
        public MythicKeystoneAffixReference[] Affixes { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MythicKeystoneAffixesIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of mythic keystone affixes.</param>
        /// <param name="affixes">References to the mythic keystone affixes.</param>
        [JsonConstructor]
        public MythicKeystoneAffixesIndex(Links links, MythicKeystoneAffixReference[] affixes)
        {
            Links = links;
            Affixes = affixes;
        }
    }
}
