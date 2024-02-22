namespace ArgentPonyWarcraftClient;

/// <summary>
/// A dungeon or raid.
/// </summary>
public record Instance
{
    /// <summary>
    /// Gets links for the instance.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of the instance.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the name of the instance.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the map of the instance.
    /// </summary>
    [JsonPropertyName("map")]
    public Map Map { get; init; }

    /// <summary>
    /// Gets the area where the instance is found.
    /// </summary>
    [JsonPropertyName("area")]
    public Area Area { get; init; }

    /// <summary>
    /// Gets the description of the instance.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; init; }

    /// <summary>
    /// Gets the encounters found within the instance.
    /// </summary>
    [JsonPropertyName("encounters")]
    public EncounterReference[] Encounters { get; init; }

    /// <summary>
    /// Gets a reference to the game expansion where this instance was introduced.
    /// </summary>
    [JsonPropertyName("expansion")]
    public ExpansionReference Expansion { get; init; }

    /// <summary>
    /// Gets the location of the instance.
    /// </summary>
    [JsonPropertyName("location")]
    public Location Location { get; init; }

    /// <summary>
    /// Gets the available difficulty modes for the instance.
    /// </summary>
    [JsonPropertyName("modes")]
    public InstanceMode[] Modes { get; init; }

    /// <summary>
    /// Gets the media associated with the instance.
    /// </summary>
    [JsonPropertyName("media")]
    public Media Media { get; init; }

    /// <summary>
    /// Gets the minimum character level for the instance.
    /// </summary>
    [JsonPropertyName("minimum_level")]
    public int MinimumLevel { get; init; }

    /// <summary>
    /// Gets the category of the instance (i.e., "DUNGEON" or "RAID").
    /// </summary>
    [JsonPropertyName("category")]
    public InstanceCategory Category { get; init; }

    /// <summary>
    /// Gets the order index of the instance.
    /// </summary>
    [JsonPropertyName("order_index")]
    public int OrderIndex { get; init; }
}
