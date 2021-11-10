namespace ArgentPonyWarcraftClient;

/// <summary>
/// A boss encounter in an dungeon or raid.
/// </summary>
public record Encounter
{
    /// <summary>
    /// Gets links for the encounter.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of the encounter.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the name of the encounter.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the description of the encounter.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; init; }

    /// <summary>
    /// Gets the creatures involved in the encounter.
    /// </summary>
    [JsonPropertyName("creatures")]
    public EncounterCreature[] Creatures { get; init; }

    /// <summary>
    /// Gets the items that can appear as loot from the encounter.
    /// </summary>
    [JsonPropertyName("items")]
    public EncounterItem[] Items { get; init; }

    /// <summary>
    /// Gets the stages of the encounter.
    /// </summary>
    [JsonPropertyName("sections")]
    public EncounterSection[] Sections { get; init; }

    /// <summary>
    /// Gets a reference to the dungeon or raid where this encounter takes place.
    /// </summary>
    [JsonPropertyName("instance")]
    public InstanceReference Instance { get; init; }

    /// <summary>
    /// Gets the category of the instance.
    /// </summary>
    [JsonPropertyName("category")]
    public InstanceCategory Category { get; init; }

    /// <summary>
    /// Gets the difficulty modes of the encounter.
    /// </summary>
    [JsonPropertyName("modes")]
    public EnumType[] Modes { get; init; }
}
