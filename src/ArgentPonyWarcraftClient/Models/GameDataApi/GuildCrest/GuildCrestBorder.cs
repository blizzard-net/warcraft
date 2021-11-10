namespace ArgentPonyWarcraftClient;

/// <summary>
/// A guild crest border.
/// </summary>
public record GuildCrestBorder
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
}
