namespace ArgentPonyWarcraftClient;

/// <summary>
/// A spell.
/// </summary>
public record Spell
{
    /// <summary>
    /// Gets links for the spell.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of the spell.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the name of the spell.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the description of the spell.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; init; }

    /// <summary>
    /// Gets the media associated with this spell.
    /// </summary>
    [JsonPropertyName("media")]
    public Media Media { get; init; }
}
