using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of auctions.
    /// </summary>
    public record AuctionsIndex
    {
        /// <summary>
        /// Gets links for the index of auctions.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the connected realm associated with the auctions.
        /// </summary>
        [JsonPropertyName("connected_realm")]
        public Self ConnectedRealm { get; }

        /// <summary>
        /// Gets the auctions.
        /// </summary>
        [JsonPropertyName("auctions")]
        public Auction[] Auctions { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuctionsIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of auctions.</param>
        /// <param name="connectedRealm">The connected realm associated with the auctions.</param>
        /// <param name="auctions">The auctions.</param>
        [JsonConstructor]
        public AuctionsIndex(Links links, Self connectedRealm, Auction[] auctions)
        {
            Links = links;
            ConnectedRealm = connectedRealm;
            Auctions = auctions;
        }
    }
}
