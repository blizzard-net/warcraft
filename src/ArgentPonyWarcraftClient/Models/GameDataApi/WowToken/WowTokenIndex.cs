namespace ArgentPonyWarcraftClient;

/// <summary>
/// A WoW Token index.
/// </summary>
public record WowTokenIndex
{
    /// <summary>
    /// Gets links for the WoW Token index.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the last updated timestamp for the WoW Token index.
    /// </summary>
    [JsonPropertyName("last_updated_timestamp")]
    public DateTimeOffset LastUpdatedTimestamp { get; init; }

    /// <summary>
    /// Gets the price for a Wow token.
    /// </summary>
    [JsonPropertyName("price")]
    public long Price { get; init; }
}
