namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a zone.
/// </summary>
public record ZoneReferenceSlug
{
    /// <summary>
    /// Gets the slug for the zone.
    /// </summary>
    [JsonPropertyName("slug")]
    public string Slug { get; init; }
}
