namespace ArgentPonyWarcraftClient;

/// <summary>
/// Pet media.
/// </summary>
public record PetMedia
{
    /// <summary>
    /// Gets links for the pet media.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a collection of media assets.
    /// </summary>
    [JsonPropertyName("assets")]
    public Asset[] Assets { get; init; }

    /// <summary>
    /// Gets the Id of the pet that the media belongs to.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
