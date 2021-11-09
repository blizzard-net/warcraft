namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of playable classes.
/// </summary>
public record PlayableClassesIndex
{
    /// <summary>
    /// Gets links for the index of playable classes.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets references to the playable classes.
    /// </summary>
    [JsonPropertyName("classes")]
    public PlayableClassReference[] Classes { get; init; }
}
