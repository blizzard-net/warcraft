namespace ArgentPonyWarcraftClient;

/// <summary>
/// Mythic keystone affix media.
/// </summary>
public record MythicKeystoneAffixMedia
{
    /// <summary>
    /// Gets links for the mythic keystone affix media.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a collection of media assets.
    /// </summary>
    [JsonPropertyName("assets")]
    public Asset[] Assets { get; init; }

    /// <summary>
    /// Gets the ID of the mythic keystone affix.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
