namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of guild crest media.
/// </summary>
public record GuildCrestComponentsIndex
{
    /// <summary>
    /// Gets links for the index of guild crest media.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the guild crest emblems.
    /// </summary>
    [JsonPropertyName("emblems")]
    public GuildCrestEmblem[] Emblems { get; init; }

    /// <summary>
    /// Gets the guild crest borders.
    /// </summary>
    [JsonPropertyName("borders")]
    public GuildCrestBorder[] Borders { get; init; }

    /// <summary>
    /// Gets the guild crest colors.
    /// </summary>
    [JsonPropertyName("colors")]
    public GuildCrestColors Colors { get; init; }
}
