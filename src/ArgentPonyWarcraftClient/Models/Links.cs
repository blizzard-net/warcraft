namespace ArgentPonyWarcraftClient;

/// <summary>
/// A collection of links.
/// </summary>
public record Links
{
    /// <summary>
    /// Gets a self-reference.
    /// </summary>
    [JsonPropertyName("self")]
    public Self Self { get; init; }
}
