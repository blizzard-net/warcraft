namespace ArgentPonyWarcraftClient;

/// <summary>
/// A summary of a character's completed dungeons.
/// </summary>
public record CharacterDungeons
{
    /// <summary>
    /// Gets links for the character's completed instances.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the character's completed instances, organized by game expansion.
    /// </summary>
    [JsonPropertyName("expansions")]
    public CharacterExpansionInstances[] Expansions { get; init; }
}
