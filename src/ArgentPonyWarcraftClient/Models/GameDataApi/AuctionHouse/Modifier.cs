namespace ArgentPonyWarcraftClient;

/// <summary>
/// An item modifier.
/// </summary>
public record Modifier
{
    /// <summary>
    /// Gets the type of modifier.
    /// </summary>
    [JsonPropertyName("type")]
    public int Type { get; init; }

    /// <summary>
    /// Gets the value of the modifier.
    /// </summary>
    [JsonPropertyName("value")]
    public int Value { get; init; }
}
