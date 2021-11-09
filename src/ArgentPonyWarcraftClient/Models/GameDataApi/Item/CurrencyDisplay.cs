namespace ArgentPonyWarcraftClient;

/// <summary>
/// Currency display strings for a price.
/// </summary>
public record CurrencyDisplay
{
    /// <summary>
    /// Gets the header.
    /// </summary>
    [JsonPropertyName("header")]
    public string Header { get; init; }

    /// <summary>
    /// Gets the gold portion of the price.
    /// </summary>
    [JsonPropertyName("gold")]
    public string Gold { get; init; }

    /// <summary>
    /// Gets the silver portion of the price.
    /// </summary>
    [JsonPropertyName("silver")]
    public string Silver { get; init; }

    /// <summary>
    /// Gets the copper portion of the price.
    /// </summary>
    [JsonPropertyName("copper")]
    public string Copper { get; init; }
}
