namespace ArgentPonyWarcraftClient;

/// <summary>
/// A mythic keystone affix.
/// </summary>
public record MythicKeystoneAffix
{
    /// <summary>
    /// Gets links for the mythic keystone affix.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of the mythic keystone affix.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the name of the mythic keystone affix.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the description of the mythic keystone affix.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; init; }

    /// <summary>
    /// Gets the media for this mythic keystone affix.
    /// </summary>
    [JsonPropertyName("media")]
    public Media Media { get; init; }
}
