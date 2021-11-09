namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of talents.
/// </summary>
public record TalentsIndex
{
    /// <summary>
    /// Gets links for the index of talents.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets references to talents.
    /// </summary>
    [JsonPropertyName("talents")]
    public TalentReference[] Talents { get; init; }
}
