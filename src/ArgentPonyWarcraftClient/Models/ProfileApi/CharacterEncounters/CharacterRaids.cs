namespace ArgentPonyWarcraftClient;

/// <summary>
/// A summary of a character's completed raids.
/// </summary>
public record CharacterRaids
{
    /// <summary>
    /// Gets links for the character's completed instances.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a reference to the character.
    /// </summary>
    [JsonPropertyName("character")]
    public CharacterReference Character { get; init; }

    /// <summary>
    /// Gets the character's completed instances, organized by game expansion.
    /// </summary>
    [JsonPropertyName("expansions")]
    public CharacterExpansionInstances[] Expansions { get; init; }
}
