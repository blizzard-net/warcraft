namespace ArgentPonyWarcraftClient;

/// <summary>
/// A color.
/// </summary>
public record Color
{
    /// <summary>
    /// Gets the ID of the color.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the RGBA color information.
    /// </summary>
    [JsonPropertyName("rgba")]
    public ColorDetails Rgba { get; init; }
}
