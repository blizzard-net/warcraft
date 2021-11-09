namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reputation tier.
/// </summary>
public record ReputationTier
{
    /// <summary>
    /// Gets the name of the reputation tier.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the minimum value of the reputation tier.
    /// </summary>
    [JsonPropertyName("min_value")]
    public int MinValue { get; init; }

    /// <summary>
    /// Gets the maximum value of the reputation tier.
    /// </summary>
    [JsonPropertyName("max_value")]
    public int MaxValue { get; init; }

    /// <summary>
    /// Gets the ID of the reputation tier.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
