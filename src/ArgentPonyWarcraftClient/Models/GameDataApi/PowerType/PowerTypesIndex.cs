namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of power types.
/// </summary>
public record PowerTypesIndex
{
    /// <summary>
    /// Gets links for the index of power types.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets references to the power types.
    /// </summary>
    [JsonPropertyName("power_types")]
    public PowerTypeReference[] PowerTypes { get; init; }
}
