namespace ArgentPonyWarcraftClient;

/// <summary>
/// Profession media.
/// </summary>
public record ProfessionMedia
{
    /// <summary>
    /// Gets links for the profession media.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a collection of media assets.
    /// </summary>
    [JsonPropertyName("assets")]
    public Asset[] Assets { get; init; }

    /// <summary>
    /// Gets the ID of the profession.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
