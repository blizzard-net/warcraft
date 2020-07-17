using System.Text.Json.Serialization;

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
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the item being auctioned.
        /// </summary>
        [JsonPropertyName("item")]
        public AuctionItem Item { get; set; }

        /// <summary>
        /// Gets the quantity of the item being auctioned.
        /// </summary>
        [JsonPropertyName("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// Gets the unit price of the item being auctioned.
        /// </summary>
        [JsonPropertyName("unit_price")]
        public long? UnitPrice { get; set; }

        /// <summary>
        /// Gets the approximate time remaining for the auction (SHORT or VERY_LONG).
        /// </summary>
        [JsonPropertyName("time_left")]
        public string TimeLeft { get; set; }

        /// <summary>
        /// Gets the current bid, if any, for the auction.
        /// </summary>
        [JsonPropertyName("bid")]
        public long? Bid { get; set; }

        /// <summary>
        /// Gets the buyout price of the item being auctioned.
        /// </summary>
        [JsonPropertyName("buyout")]
        public long? Buyout { get; set; }
    }
}
