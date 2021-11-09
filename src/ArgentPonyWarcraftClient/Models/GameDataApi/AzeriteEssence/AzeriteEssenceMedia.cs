namespace ArgentPonyWarcraftClient;

/// <summary>
/// Media for an azerite essence.
/// </summary>
public record AzeriteEssenceMedia
{
    /// <summary>
    /// Gets links for the azerite essence media.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a collection of media assets.
    /// </summary>
    [JsonPropertyName("assets")]
    public Asset[] Assets { get; init; }

    /// <summary>
    /// Gets the ID of the azerite essence.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
