namespace ArgentPonyWarcraftClient;

/// <summary>
/// Spell media.
/// </summary>
public record SpellMedia
{
    /// <summary>
    /// Gets links for the spell media.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a collection of media assets.
    /// </summary>
    [JsonPropertyName("assets")]
    public Asset[] Assets { get; init; }

    /// <summary>
    /// Gets the ID of the spell.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
