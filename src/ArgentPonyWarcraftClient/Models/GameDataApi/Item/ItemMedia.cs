namespace ArgentPonyWarcraftClient;

/// <summary>
/// Item media.
/// </summary>
public record ItemMedia
{
    /// <summary>
    /// Gets links for the achievement media.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a collection of media assets.
    /// </summary>
    [JsonPropertyName("assets")]
    public Asset[] Assets { get; init; }

    /// <summary>
    /// Gets the ID of the item.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
