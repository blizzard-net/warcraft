namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of conduits.
/// </summary>
public record ConduitsIndex
{
    /// <summary>
    /// Gets the links for the index of conduits.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the conduit references.
    /// </summary>
    [JsonPropertyName("conduits")]
    public ConduitReference[] Conduits { get; init; }
}
