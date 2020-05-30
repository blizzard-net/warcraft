using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An auction.
    /// </summary>
    public class Auction
    {
        /// <summary>
        /// Gets the ID of the auction.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the item being auctioned.
        /// </summary>
        [JsonProperty("item")]
        public AuctionItem Item { get; set; }

        /// <summary>
        /// Gets the quantity of the item being auctioned.
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// Gets the unit price of the item being auctioned.
        /// </summary>
        [JsonProperty("unit_price", NullValueHandling = NullValueHandling.Ignore)]
        public long? UnitPrice { get; set; }

        /// <summary>
        /// Gets the approximate time remaining for the auction.
        /// </summary>
        [JsonProperty("time_left")]
        [JsonConverter(typeof(TimeLeftConverter))]
        public TimeLeft TimeLeft { get; set; }

        /// <summary>
        /// Gets the current bid, if any, for the auction.
        /// </summary>
        [JsonProperty("bid", NullValueHandling = NullValueHandling.Ignore)]
        public long? Bid { get; set; }

        /// <summary>
        /// Gets the buyout price of the item being auctioned.
        /// </summary>
        [JsonProperty("buyout", NullValueHandling = NullValueHandling.Ignore)]
        public long? Buyout { get; set; }
    }
}
