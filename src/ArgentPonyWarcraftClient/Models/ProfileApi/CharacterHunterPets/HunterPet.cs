namespace ArgentPonyWarcraftClient;

/// <summary>
/// A hunter pet.
/// </summary>
public record HunterPet
{
    /// <summary>
    /// Gets the name of the hunter pet.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the level of the hunter pet.
    /// </summary>
    [JsonPropertyName("level")]
    public int Level { get; init; }

    /// <summary>
    /// Gets a reference to the creature type of the hunter pet.
    /// </summary>
    [JsonPropertyName("creature")]
    public CreatureReference Creature { get; init; }

    /// <summary>
    /// Gets the slot to which the hunter pet is assigned.
    /// </summary>
    [JsonPropertyName("slot")]
    public int Slot { get; init; }

    /// <summary>
    /// Gets a value indicating whether the hunter pet is active.
    /// </summary>
    [JsonPropertyName("is_active")]
    public bool? IsActive { get; init; }

    /// <summary>
    /// Gets a reference to creature display media for the hunter pet.
    /// </summary>
    [JsonPropertyName("creature_display")]
    public CreatureDisplayMediaReference CreatureDisplay { get; init; }

    /// <summary>
    /// Gets a value indicating whether the hunter pet is summoned.
    /// </summary>
    [JsonPropertyName("is_summoned")]
    public bool? IsSummoned { get; init; }
}
