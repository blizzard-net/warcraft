namespace ArgentPonyWarcraftClient;

/// <summary>
/// A monetary amount.
/// </summary>
public record Money
{
    /// <summary>
    /// Gets the numerical value of the money.
    /// </summary>
    [JsonPropertyName("value")]
    public long Value { get; init; }

    /// <summary>
    /// Gets the monetary amount as gold, silver, and copper units.
    /// </summary>
    [JsonPropertyName("units")]
    public Units Units { get; init; }
}
