namespace ArgentPonyWarcraftClient;

/// <summary>
/// A creature family.
/// </summary>
public record CreatureFamily
{
    /// <summary>
    /// Gets links for the creature family.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of the creature family.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the name of the creature family.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the specialization of the creature family.
    /// </summary>
    [JsonPropertyName("specialization")]
    public PlayableSpecializationReference Specialization { get; init; }

    /// <summary>
    /// Gets media for the creature family.
    /// </summary>
    [JsonPropertyName("media")]
    public Media Media { get; init; }
}
