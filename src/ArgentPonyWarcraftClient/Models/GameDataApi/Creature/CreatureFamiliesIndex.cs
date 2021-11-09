namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of creature families.
/// </summary>
public record CreatureFamiliesIndex
{
    /// <summary>
    /// Gets links for the index of creature families.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets references to the creature families.
    /// </summary>
    [JsonPropertyName("creature_families")]
    public CreatureFamilyReference[] CreatureFamilies { get; init; }
}
