namespace ArgentPonyWarcraftClient;

/// <summary>
/// A map.
/// </summary>
public record Map
{
    /// <summary>
    /// Gets the name of the map.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the map.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
