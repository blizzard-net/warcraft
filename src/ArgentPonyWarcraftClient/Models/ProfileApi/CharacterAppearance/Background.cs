namespace ArgentPonyWarcraftClient;

/// <summary>
/// A background.
/// </summary>
public record Background
{
    /// <summary>
    /// Gets the background color.
    /// </summary>
    [JsonPropertyName("color")]
    public Color Color { get; init; }
}
