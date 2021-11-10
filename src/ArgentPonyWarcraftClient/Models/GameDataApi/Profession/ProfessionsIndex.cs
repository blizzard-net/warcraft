namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of professions.
/// </summary>
public record ProfessionsIndex
{
    /// <summary>
    /// Gets links for the index of professions.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets references to the professions.
    /// </summary>
    [JsonPropertyName("professions")]
    public ProfessionReference[] Professions { get; init; }
}
