namespace ArgentPonyWarcraftClient;

/// <summary>
/// A creature type.
/// </summary>
public record CreatureType
{
    /// <summary>
    /// Gets links for the creature type.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of the creature type.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the name of the creature type.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }
}
