namespace ArgentPonyWarcraftClient;

/// <summary>
/// A sell price.
/// </summary>
public record SellPrice
{
    /// <summary>
    /// Gets the numeric value of the sell price.
    /// </summary>
    [JsonPropertyName("value")]
    public long Value { get; init; }

    /// <summary>
    /// Gets the currency display information for the sell price.
    /// </summary>
    [JsonPropertyName("display_strings")]
    public CurrencyDisplay DisplayStrings { get; init; }
}
