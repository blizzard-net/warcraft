namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of realms.
/// </summary>
public record RealmsIndex
{
    /// <summary>
    /// Gets links for the index of realms.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets references to the realms.
    /// </summary>
    [JsonPropertyName("realms")]
    public RealmReference[] Realms { get; init; }
}
