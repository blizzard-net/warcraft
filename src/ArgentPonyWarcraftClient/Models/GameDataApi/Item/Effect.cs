namespace ArgentPonyWarcraftClient;

/// <summary>
/// A set bonus that can be activated by equipping items from the set.
/// </summary>
public record Effect
{
    /// <summary>
    /// Gets the display string for the effect.
    /// </summary>
    [JsonPropertyName("display_string")]
    public string DisplayString { get; init; }

    /// <summary>
    /// Gets the required count of items in the set that must be equipped to activate the effect.
    /// </summary>
    [JsonPropertyName("required_count")]
    public int RequiredCount { get; init; }
}
