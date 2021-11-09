namespace ArgentPonyWarcraftClient;

/// <summary>
/// Encounter statistics for a character in an instance.
/// </summary>
public record CharacterEncounter
{
    /// <summary>
    /// Gets a reference to the encounter.
    /// </summary>
    [JsonPropertyName("encounter")]
    public EncounterReference Encounter { get; init; }

    /// <summary>
    /// Gets the number of times the encounter has been completed by the character.
    /// </summary>
    [JsonPropertyName("completed_count")]
    public int CompletedCount { get; init; }

    /// <summary>
    /// Gets the timestamp of the last kill.
    /// </summary>
    [JsonPropertyName("last_kill_timestamp")]
    public DateTimeOffset LastKillTimestamp { get; init; }
}
