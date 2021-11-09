namespace ArgentPonyWarcraftClient;

/// <summary>
/// A creature.
/// </summary>
public record EncounterCreature
{
    /// <summary>
    /// Gets the ID of the creature.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the name of the creature.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the media associated with the creature.
    /// </summary>
    [JsonPropertyName("creature_display")]
    public Media CreatureDisplay { get; init; }
}
