namespace ArgentPonyWarcraftClient;

/// <summary>
/// RGBA color information.
/// </summary>
public record ColorDetails
{
    /// <summary>
    /// Gets the red channel value for the color.
    /// </summary>
    [JsonPropertyName("r")]
    public int Red { get; init; }

    /// <summary>
    /// Gets the green channel value for the color.
    /// </summary>
    [JsonPropertyName("g")]
    public int Green { get; init; }

    /// <summary>
    /// Gets the blue channel value for the color.
    /// </summary>
    [JsonPropertyName("b")]
    public int Blue { get; init; }

    /// <summary>
    /// Gets the alpha (opacity) channel value for the color.
    /// </summary>
    [JsonPropertyName("a")]
    public float Alpha { get; init; }
}
