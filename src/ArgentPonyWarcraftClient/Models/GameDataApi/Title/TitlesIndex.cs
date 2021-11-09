namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of titles.
/// </summary>
public record TitlesIndex
{
    /// <summary>
    /// Gets links for the index of titles.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets references to the titles.
    /// </summary>
    [JsonPropertyName("titles")]
    public TitleReferenceWithDisplayString[] Titles { get; init; }
}
