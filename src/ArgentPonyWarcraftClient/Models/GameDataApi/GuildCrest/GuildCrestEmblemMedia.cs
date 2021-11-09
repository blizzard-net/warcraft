namespace ArgentPonyWarcraftClient;

/// <summary>
/// Media for a guild crest emblem.
/// </summary>
public record GuildCrestEmblemMedia
{
    /// <summary>
    /// Gets links for the guild crest emblem media.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a collection of media assets.
    /// </summary>
    [JsonPropertyName("assets")]
    public AssetWithoutFileDataId[] Assets { get; init; }

    /// <summary>
    /// Gets the ID of the guild crest emblem.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
