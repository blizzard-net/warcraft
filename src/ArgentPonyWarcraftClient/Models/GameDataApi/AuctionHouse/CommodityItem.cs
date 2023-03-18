namespace ArgentPonyWarcraftClient;

/// <summary>
/// A commodity item.
/// </summary>
public record CommodityItem
{
    /// <summary>
    /// Gets the ID of the commodity item.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
