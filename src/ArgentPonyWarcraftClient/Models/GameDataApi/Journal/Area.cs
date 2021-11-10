namespace ArgentPonyWarcraftClient;

/// <summary>
/// An area.
/// </summary>
public record Area
{
    /// <summary>
    /// Gets the name of the area.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the area.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
