using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An auction.
    /// </summary>
    public record Auction
    {
        /// <summary>
        /// Gets the ID of the auction.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the item being auctioned.
        /// </summary>
        [JsonPropertyName("item")]
        public AuctionItem Item { get; }

        /// <summary>
        /// Gets the quantity of the item being auctioned.
        /// </summary>
        [JsonPropertyName("quantity")]
        public int Quantity { get; }

        /// <summary>
        /// Gets the unit price of the item being auctioned.
        /// </summary>
        [JsonPropertyName("unit_price")]
        public long? UnitPrice { get; }

        /// <summary>
        /// Gets the approximate time remaining for the auction (SHORT or VERY_LONG).
        /// </summary>
        [JsonPropertyName("time_left")]
        public string TimeLeft { get; }

        /// <summary>
        /// Gets the current bid, if any, for the auction.
        /// </summary>
        [JsonPropertyName("bid")]
        public long? Bid { get; }

        /// <summary>
        /// Gets the buyout price of the item being auctioned.
        /// </summary>
        [JsonPropertyName("buyout")]
        public long? Buyout { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Auction"/> class.
        /// </summary>
        /// <param name="id">The ID of the auction.</param>
        /// <param name="item">The item being auctioned.</param>
        /// <param name="quantity">The quantity of the item being auctioned.</param>
        /// <param name="unitPrice">The unit price of the item being auctioned.</param>
        /// <param name="timeLeft">The approximate time remaining for the auction (SHORT or VERY_LONG).</param>
        /// <param name="bid">The current bid, if any, for the auction.</param>
        /// <param name="buyout">The buyout price of the item being auctioned.</param>
        [JsonConstructor]
        public Auction(int id, AuctionItem item, int quantity, long? unitPrice, string timeLeft, long? bid, long? buyout)
        {
            Id = id;
            Item = item;
            Quantity = quantity;
            UnitPrice = unitPrice;
            TimeLeft = timeLeft;
            Bid = bid;
            Buyout = buyout;
        }
    }
}
