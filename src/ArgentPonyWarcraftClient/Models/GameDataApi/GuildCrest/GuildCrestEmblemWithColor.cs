namespace ArgentPonyWarcraftClient;

/// <summary>
/// A guild crest emblem with color.
/// </summary>
public record GuildCrestEmblemWithColor
{
    /// <summary>
    /// Gets the ID of the emblem.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the media associated with the emblem.
    /// </summary>
    [JsonPropertyName("media")]
    public Media Media { get; init; }

    /// <summary>
    /// Gets the emblem color.
    /// </summary>
    [JsonPropertyName("color")]
    public Color Color { get; init; }
}
