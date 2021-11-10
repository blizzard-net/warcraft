namespace ArgentPonyWarcraftClient;

/// <summary>
/// Instance progress for a character.
/// </summary>
public record CharacterInstanceProgress
{
    /// <summary>
    /// Gets the number of times the instance has been completed by the character.
    /// </summary>
    [JsonPropertyName("completed_count")]
    public int CompletedCount { get; init; }

    /// <summary>
    /// Gets the number of times the instance has been attempted by the character.
    /// </summary>
    [JsonPropertyName("total_count")]
    public int TotalCount { get; init; }

    /// <summary>
    /// Gets encounter statistics for the instance.
    /// </summary>
    [JsonPropertyName("encounters")]
    public CharacterEncounter[] Encounters { get; init; }
}
