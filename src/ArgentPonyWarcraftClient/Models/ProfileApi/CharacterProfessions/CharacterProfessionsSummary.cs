namespace ArgentPonyWarcraftClient;

/// <summary>
/// A summary of professions for a character.
/// </summary>
public record CharacterProfessionsSummary
{
    /// <summary>
    /// Gets links for the character professions summary.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the character's primary professions.
    /// </summary>
    [JsonPropertyName("primaries")]
    public CharacterProfession[] Primaries { get; init; }

    /// <summary>
    /// Gets the character's secondary professions.
    /// </summary>
    [JsonPropertyName("secondaries")]
    public CharacterProfession[] Secondaries { get; init; }
}
