namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of covenants.
/// </summary>
public record CovenantsIndex
{
    /// <summary>
    /// Gets the links for the index of covenants.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the covenant references.
    /// </summary>
    [JsonPropertyName("covenants")]
    public CovenantReference[] Covenants { get; init; }
}
