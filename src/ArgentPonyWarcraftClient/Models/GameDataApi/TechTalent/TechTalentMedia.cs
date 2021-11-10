namespace ArgentPonyWarcraftClient;

/// <summary>
/// Media for a tech talent.
/// </summary>
public record TechTalentMedia
{
    /// <summary>
    /// Gets links for the tech talent media.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a collection media assets.
    /// </summary>
    [JsonPropertyName("assets")]
    public Asset[] Assets { get; init; }
}
