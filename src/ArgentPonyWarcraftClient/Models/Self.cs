namespace ArgentPonyWarcraftClient;

/// <summary>
/// A self-reference.
/// </summary>
public record Self
{
    /// <summary>
    /// Gets a URI for retrieving the data for this object.
    /// </summary>
    [JsonPropertyName("href")]
    public Uri Href { get; init; }
}
