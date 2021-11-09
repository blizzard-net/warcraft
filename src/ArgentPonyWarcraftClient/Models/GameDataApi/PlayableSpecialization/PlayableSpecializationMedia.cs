namespace ArgentPonyWarcraftClient;

/// <summary>
/// Playable specialization media.
/// </summary>
public record PlayableSpecializationMedia
{
    /// <summary>
    /// Gets links for the playable specialization media.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a collection of media assets.
    /// </summary>
    [JsonPropertyName("assets")]
    public Asset[] Assets { get; init; }

    /// <summary>
    /// Gets the ID of the playable specialization.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
