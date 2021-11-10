namespace ArgentPonyWarcraftClient;

/// <summary>
/// A guild crest border with color.
/// </summary>
public record GuildCrestBorderWithColor
{
    /// <summary>
    /// Gets the ID of the border.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the media associated with the border.
    /// </summary>
    [JsonPropertyName("media")]
    public Media Media { get; init; }

    /// <summary>
    /// Gets the border color.
    /// </summary>
    [JsonPropertyName("color")]
    public Color Color { get; init; }
}
