namespace ArgentPonyWarcraftClient;

/// <summary>
/// A location.
/// </summary>
public record Location
{
    /// <summary>
    /// Gets the name of the location.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the location.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
