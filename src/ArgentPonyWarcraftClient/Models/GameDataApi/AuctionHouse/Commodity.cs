namespace ArgentPonyWarcraftClient;

/// <summary>
/// A commodity.
/// </summary>
public record Commodity
{
    /// <summary>
    /// Gets the ID of the commodity.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the item being auctioned.
    /// </summary>
    [JsonPropertyName("item")]
    public CommodityItem Item { get; init; }

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
}
