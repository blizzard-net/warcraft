namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of links to other documents related to Mythic Keystone dungeons.
/// </summary>
public record MythicKeystoneIndex
{
    /// <summary>
    /// Gets links for the index of mythic keystone documents.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a link to mythic keystone seasons.
    /// </summary>
    [JsonPropertyName("seasons")]
    public Self Seasons { get; init; }

    /// <summary>
    /// Gets a link to mythic keystone dungeons.
    /// </summary>
    [JsonPropertyName("dungeons")]
    public Self Dungeons { get; init; }
}
