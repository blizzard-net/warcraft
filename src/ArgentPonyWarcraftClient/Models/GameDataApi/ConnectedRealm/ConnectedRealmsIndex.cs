namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of connected realms.
/// </summary>
public record ConnectedRealmsIndex
{
    /// <summary>
    /// Gets links for the index of connected realms.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets references to the connected realms.
    /// </summary>
    [JsonPropertyName("connected_realms")]
    public Self[] ConnectedRealms { get; init; }
}
