namespace ArgentPonyWarcraftClient;

/// <summary>
/// A guild crest emblem.
/// </summary>
public record GuildCrestEmblem
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
}
