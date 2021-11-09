namespace ArgentPonyWarcraftClient;

/// <summary>
/// A list of available guild crest colors.
/// </summary>
public record GuildCrestColors
{
    /// <summary>
    /// Gets the guild crest emblems.
    /// </summary>
    [JsonPropertyName("emblems")]
    public Color[] Emblems { get; init; }

    /// <summary>
    /// Gets the guild crest borders.
    /// </summary>
    [JsonPropertyName("borders")]
    public Color[] Borders { get; init; }

    /// <summary>
    /// Gets the guild crest borders.
    /// </summary>
    [JsonPropertyName("backgrounds")]
    public Color[] Backgrounds { get; init; }
}
