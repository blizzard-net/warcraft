namespace ArgentPonyWarcraftClient;

/// <summary>
/// An auction.
/// </summary>
public record Auction
{
    /// <summary>
    /// Gets the ID of the auction.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the item being auctioned.
    /// </summary>
    [JsonPropertyName("item")]
    public AuctionItem Item { get; init; }

    /// <summary>
    /// Gets the quantity of the item being auctioned.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int Quantity { get; init; }

    /// <summary>
    /// Gets the unit price of the item being auctioned.
    /// </summary>
    [JsonPropertyName("unit_price")]
    public long? UnitPrice { get; init; }

    /// <summary>
    /// Gets the approximate time remaining for the auction (SHORT or VERY_LONG).
    /// </summary>
    [JsonPropertyName("time_left")]
    public string TimeLeft { get; init; }

    /// <summary>
    /// Gets the current bid, if any, for the auction.
    /// </summary>
    [JsonPropertyName("bid")]
    public long? Bid { get; init; }

    /// <summary>
    /// Gets the buyout price of the item being auctioned.
    /// </summary>
    [JsonPropertyName("buyout")]
    public long? Buyout { get; init; }
}
