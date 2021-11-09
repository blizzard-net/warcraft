namespace ArgentPonyWarcraftClient;

/// <summary>
/// A summary of titles a character has obtained.
/// </summary>
public record CharacterTitlesSummary
{
    /// <summary>
    /// Gets links for the summary of titles a character has obtained.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a reference to the character.
    /// </summary>
    [JsonPropertyName("character")]
    public CharacterReference Character { get; init; }

    /// <summary>
    /// Gets the character's active title.
    /// </summary>
    [JsonPropertyName("active_title")]
    public TitleReferenceWithDisplayString ActiveTitle { get; init; }

    /// <summary>
    /// Gets references to the titles the character has obtained.
    /// </summary>
    [JsonPropertyName("titles")]
    public TitleReference[] Titles { get; init; }
}
