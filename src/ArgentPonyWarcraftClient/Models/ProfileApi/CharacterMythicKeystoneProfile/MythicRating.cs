namespace ArgentPonyWarcraftClient;

/// <summary>
/// The mythic rating for a character.
/// </summary>
public record MythicRating
{
    /// <summary>
    /// Gets the mythic rating color.
    /// </summary>
    [JsonPropertyName("color")]
    public ColorDetails Color { get; init; }

    /// <summary>
    /// Gets the mythic rating value.
    /// </summary>
    [JsonPropertyName("rating")]
    public double Rating { get; init; }
}
