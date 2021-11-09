namespace ArgentPonyWarcraftClient;

/// <summary>
/// Creature display media.
/// </summary>
public record CreatureDisplayMedia
{
    /// <summary>
    /// Gets links for the creature display media.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a collection of media assets.
    /// </summary>
    [JsonPropertyName("assets")]
    public AssetWithoutFileDataId[] Assets { get; init; }

    /// <summary>
    /// Gets the ID of the creature display.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
