namespace ArgentPonyWarcraftClient;

/// <summary>
/// A summary of a character's specializations.
/// </summary>
public record CharacterSpecializationsSummary
{
    /// <summary>
    /// Gets links for the summary of the character's specializations.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the character's specializations.
    /// </summary>
    [JsonPropertyName("specializations")]
    public CharacterSpecialization[] Specializations { get; init; }

    /// <summary>
    /// Gets the character's active specialization.
    /// </summary>
    [JsonPropertyName("active_specialization")]
    public PlayableSpecializationReference ActiveSpecialization { get; init; }

    /// <summary>
    /// Gets a reference to the character.
    /// </summary>
    [JsonPropertyName("character")]
    public CharacterReference Character { get; init; }
}
