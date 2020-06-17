using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the connected realm associated with the auctions.
        /// </summary>
        [JsonProperty("connected_realm")]
        public Self ConnectedRealm { get; set; }

        /// <summary>
        /// Gets the auctions.
        /// </summary>
        [JsonProperty("auctions")]
        public Auction[] Auctions { get; set; }
    }
}
