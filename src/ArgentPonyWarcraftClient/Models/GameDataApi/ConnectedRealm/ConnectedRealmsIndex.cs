using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of connected realms.
    /// </summary>
    public record ConnectedRealmsIndex
    {
        /// <summary>
        /// Gets links for the index of connected realms.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to the connected realms.
        /// </summary>
        [JsonPropertyName("connected_realms")]
        public Self[] ConnectedRealms { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectedRealmsIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of connected realms.</param>
        /// <param name="connectedRealms">References to the connected realms.</param>
        [JsonConstructor]
        public ConnectedRealmsIndex(Links links, Self[] connectedRealms)
        {
            Links = links;
            ConnectedRealms = connectedRealms;
        }
    }
}
