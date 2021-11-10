namespace ArgentPonyWarcraftClient;

/// <summary>
/// The gender-specific names for a playable class, race, or title.
/// </summary>
public record GenderName
{
    /// <summary>
    /// Gets the name for male characters.
    /// </summary>
    [JsonPropertyName("male")]
    public string Male { get; init; }

    /// <summary>
    /// Gets the name for female characters.
    /// </summary>
    [JsonPropertyName("female")]
    public string Female { get; init; }
}
