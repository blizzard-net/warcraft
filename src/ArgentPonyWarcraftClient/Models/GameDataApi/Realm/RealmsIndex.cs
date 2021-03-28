using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of realms.
    /// </summary>
    public record RealmsIndex
    {
        /// <summary>
        /// Gets links for the index of realms.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to the realms.
        /// </summary>
        [JsonPropertyName("realms")]
        public RealmReference[] Realms { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealmsIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of realms.</param>
        /// <param name="realms">References to the realms.</param>
        [JsonConstructor]
        public RealmsIndex(Links links, RealmReference[] realms)
        {
            Links = links;
            Realms = realms;
        }
    }
}
