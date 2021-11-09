namespace ArgentPonyWarcraftClient;

/// <summary>
/// A character's completed instances for a game expansion.
/// </summary>
public record CharacterExpansionInstances
{
    /// <summary>
    /// Gets a reference to a game expansion.
    /// </summary>
    [JsonPropertyName("expansion")]
    public ExpansionReference Expansion { get; init; }

    /// <summary>
    /// Gets the character's completed instances for the game expansion.
    /// </summary>
    [JsonPropertyName("instances")]
    public CharacterInstance[] Instances { get; init; }
}
