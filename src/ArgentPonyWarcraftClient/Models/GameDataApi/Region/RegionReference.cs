namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a region.
/// </summary>
public record RegionReference
{
    /// <summary>
    /// Gets the key for the region.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the region.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the region.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
