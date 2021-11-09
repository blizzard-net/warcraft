namespace ArgentPonyWarcraftClient;

/// <summary>
/// Display details for a stat modifier.
/// </summary>
public record StatDisplay
{
    /// <summary>
    /// Gets the display string for the stat.
    /// </summary>
    [JsonPropertyName("display_string")]
    public string DisplayString { get; init; }

    /// <summary>
    /// Gets the color associated with the stat.
    /// </summary>
    [JsonPropertyName("color")]
    public ColorDetails Color { get; init; }
}
