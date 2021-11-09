namespace ArgentPonyWarcraftClient;

/// <summary>
/// A media reference.
/// </summary>
public record Media
{
    /// <summary>
    /// Gets the key for the media.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the ID of the media.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
