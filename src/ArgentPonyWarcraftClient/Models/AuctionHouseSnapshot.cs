using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An auction house snapshot, loaded from an auction file.
    /// </summary>
    public class AuctionHouseSnapshot
    {
        /// <summary>
        /// Gets or sets the realms with access to these auctions.
        /// </summary>
        [JsonProperty("realms")]
        public IList<AuctionRealm> Realms { get; set; }

        /// <summary>
        /// Gets or sets the auctions.
        /// </summary>
        [JsonProperty("auctions")]
        public IList<Auction> Auctions { get; set; }
    }
}
