namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of commodities.
/// </summary>
public record CommoditiesIndex
{
    /// <summary>
    /// Gets links for the index of commodities.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the auctions.
    /// </summary>
    [JsonPropertyName("auctions")]
    public Commodity[] Auctions { get; init; }
}
