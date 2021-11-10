namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of tech talents.
/// </summary>
public record TechTalentsIndex
{
    /// <summary>
    /// Gets links for the index of tech talents.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the references to the tech talents.
    /// </summary>
    [JsonPropertyName("talents")]
    public TechTalentReference[] Talents { get; init; }
}
