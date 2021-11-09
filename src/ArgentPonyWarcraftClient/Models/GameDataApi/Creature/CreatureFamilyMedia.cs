namespace ArgentPonyWarcraftClient;

/// <summary>
/// Creature family media.
/// </summary>
public record CreatureFamilyMedia
{
    /// <summary>
    /// Gets links for the creature family media.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a collection of media assets.
    /// </summary>
    [JsonPropertyName("assets")]
    public Asset[] Assets { get; init; }

    /// <summary>
    /// Gets the ID of the creature family.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
