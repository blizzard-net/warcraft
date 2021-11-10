namespace ArgentPonyWarcraftClient;

/// <summary>
/// Requirements for an item.
/// </summary>
public record Requirements
{
    /// <summary>
    /// Gets the required level for using an item.
    /// </summary>
    [JsonPropertyName("level")]
    public DescribedValue Level { get; init; }

    /// <summary>
    /// Gets the required faction for using an item.
    /// </summary>
    [JsonPropertyName("faction")]
    public FactionRequirement Faction { get; init; }
}
