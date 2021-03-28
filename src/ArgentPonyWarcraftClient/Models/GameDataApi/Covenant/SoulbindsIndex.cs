using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of soulbinds.
    /// </summary>
    public record SoulbindsIndex
    {
        /// <summary>
        /// Gets the links for the index of soulbinds.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the soulbind references.
        /// </summary>
        [JsonPropertyName("soulbinds")]
        public SoulbindReference[] Soulbinds { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SoulbindsIndex"/> class.
        /// </summary>
        /// <param name="links">The links for the index of soulbinds.</param>
        /// <param name="soulbinds">The soulbind references.</param>
        [JsonConstructor]
        public SoulbindsIndex(Links links, SoulbindReference[] soulbinds)
        {
            Links = links;
            Soulbinds = soulbinds;
        }
    }
}
