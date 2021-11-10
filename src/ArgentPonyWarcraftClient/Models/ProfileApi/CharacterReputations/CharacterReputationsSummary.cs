namespace ArgentPonyWarcraftClient;

/// <summary>
/// A summary of a character's reputations.
/// </summary>
public record CharacterReputationsSummary
{
    /// <summary>
    /// Gets links for the summary of the character's reputations.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a reference to the character.
    /// </summary>
    [JsonPropertyName("character")]
    public CharacterReference Character { get; init; }

    /// <summary>
    /// Gets 
    /// </summary>
    [JsonPropertyName("reputations")]
    public Reputation[] Reputations { get; init; }
}
