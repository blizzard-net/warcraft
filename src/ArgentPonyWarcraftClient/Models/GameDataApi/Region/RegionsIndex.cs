namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of regions.
/// </summary>
public record RegionsIndex
{
    /// <summary>
    /// Gets links for the index of regions.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets references to the regions.
    /// </summary>
    [JsonPropertyName("regions")]
    public Self[] Regions { get; init; }
}
