namespace ArgentPonyWarcraftClient;

/// <summary>
/// The gender-specific description for a playable specialization.
/// </summary>
public record GenderDescription
{
    /// <summary>
    /// Gets the description for male characters of a playable specialization.
    /// </summary>
    [JsonPropertyName("male")]
    public string Male { get; init; }

    /// <summary>
    /// Gets the description for female characters of a playable specialization.
    /// </summary>
    [JsonPropertyName("female")]
    public string Female { get; init; }
}
