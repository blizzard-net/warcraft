using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of conduits.
    /// </summary>
    public record ConduitsIndex
    {
        /// <summary>
        /// Gets the links for the index of conduits.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the conduit references.
        /// </summary>
        [JsonPropertyName("conduits")]
        public ConduitReference[] Conduits { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConduitsIndex"/> class.
        /// </summary>
        /// <param name="links">The links for the index of conduits.</param>
        /// <param name="conduits">The conduit references.</param>
        [JsonConstructor]
        public ConduitsIndex(Links links, ConduitReference[] conduits)
        {
            Links = links;
            Conduits = conduits;
        }
    }
}
