namespace ArgentPonyWarcraftClient;

/// <summary>
/// Gets a name description modifier for an item.
/// </summary>
public record NameDescription
{
    /// <summary>
    /// Gets the display string for the 
    /// </summary>
    [JsonPropertyName("display_string")]
    public string DisplayString { get; init; }

    /// <summary>
    /// Gets the RGBA color information.
    /// </summary>
    [JsonPropertyName("color")]
    public ColorDetails Color { get; init; }
}
