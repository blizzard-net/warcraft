namespace ArgentPonyWarcraftClient;

/// <summary>
/// A creature.
/// </summary>
public record Creature
{
    /// <summary>
    /// Gets links for the creature.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

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
    /// Gets the type of the creature.
    /// </summary>
    [JsonPropertyName("type")]
    public CreatureTypeReference Type { get; init; }

    /// <summary>
    /// Gets the family of the creature.
    /// </summary>
    [JsonPropertyName("family")]
    public CreatureFamilyReference Family { get; init; }

    /// <summary>
    /// Gets the creature display media for this creature.
    /// </summary>
    [JsonPropertyName("creature_displays")]
    public Media[] CreatureDisplays { get; init; }

    /// <summary>
    /// Gets a value indicating whether the creature can be tamed.
    /// </summary>
    [JsonPropertyName("is_tameable")]
    public bool IsTameable { get; init; }
}
