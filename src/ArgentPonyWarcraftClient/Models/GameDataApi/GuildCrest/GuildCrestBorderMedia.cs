namespace ArgentPonyWarcraftClient;

/// <summary>
/// Media for a guild crest border.
/// </summary>
public record GuildCrestBorderMedia
{
    /// <summary>
    /// Gets links for the guild crest border media.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a collection of media assets.
    /// </summary>
    [JsonPropertyName("assets")]
    public AssetWithoutFileDataId[] Assets { get; init; }

    /// <summary>
    /// Gets the ID of the guild crest border.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
