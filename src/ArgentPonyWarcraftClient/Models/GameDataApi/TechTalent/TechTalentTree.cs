namespace ArgentPonyWarcraftClient;

/// <summary>
/// A tech talent tree.
/// </summary>
public record TechTalentTree
{
    /// <summary>
    /// Gets links for the tech talent tree.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the Id for the tech talent tree.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// The maximum tiers of the talent tree.
    /// </summary>
    [JsonPropertyName("max_tiers")]
    public int MaxTiers { get; init; }

    /// <summary>
    /// The collection of talents in the tech talent tree.
    /// </summary>
    [JsonPropertyName("talents")]
    public TechTalentReference[] Talents { get; init; }
}
