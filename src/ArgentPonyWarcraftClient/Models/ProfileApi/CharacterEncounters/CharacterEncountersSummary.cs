namespace ArgentPonyWarcraftClient;

/// <summary>
/// A summary of a character's encounters.
/// </summary>
public record CharacterEncountersSummary
{
    /// <summary>
    /// Gets links for the character encounters summary.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a reference to the character.
    /// </summary>
    [JsonPropertyName("character")]
    public CharacterReference Character { get; init; }

    /// <summary>
    /// Gets a link to the character's dungeon encounters.
    /// </summary>
    [JsonPropertyName("dungeons")]
    public Self Dungeons { get; init; }

    /// <summary>
    /// Gets a link to the character's raid encounters.
    /// </summary>
    [JsonPropertyName("raids")]
    public Self Raids { get; init; }
}
