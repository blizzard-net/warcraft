using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of covenants.
    /// </summary>
    public record CovenantsIndex
    {
        /// <summary>
        /// Gets the links for the index of covenants.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the covenant references.
        /// </summary>
        [JsonPropertyName("covenants")]
        public CovenantReference[] Covenants { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CovenantsIndex"/> class.
        /// </summary>
        /// <param name="links">The links for the index of covenants.</param>
        /// <param name="covenants">The covenant references.</param>
        [JsonConstructor]
        public CovenantsIndex(Links links, CovenantReference[] covenants)
        {
            Links = links;
            Covenants = covenants;
        }
    }
}
