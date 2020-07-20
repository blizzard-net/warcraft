using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of auctions.
    /// </summary>
    public class AuctionsIndex
    {
        /// <summary>
        /// Gets links for the index of auctions.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the connected realm associated with the auctions.
        /// </summary>
        [JsonPropertyName("connected_realm")]
        public Self ConnectedRealm { get; set; }

        /// <summary>
        /// Gets the auctions.
        /// </summary>
        [JsonPropertyName("auctions")]
        public Auction[] Auctions { get; set; }
    }
}
