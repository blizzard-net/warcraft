namespace ArgentPonyWarcraftClient;

/// <summary>
/// Playable class media.
/// </summary>
public record PlayableClassMedia
{
    /// <summary>
    /// Gets links for the playable class media.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a collection of media assets.
    /// </summary>
    [JsonPropertyName("assets")]
    public Asset[] Assets { get; init; }

    /// <summary>
    /// Gets the ID of the playable class.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
