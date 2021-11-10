namespace ArgentPonyWarcraftClient;

/// <summary>
/// A mount.
/// </summary>
public record Mount
{
    /// <summary>
    /// Gets links for the mount.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of the mount.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the name of the mount.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the creature displays media for the mount.
    /// </summary>
    [JsonPropertyName("creature_displays")]
    public Media[] CreatureDisplays { get; init; }

    /// <summary>
    /// Gets the description of the mount.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; init; }

    /// <summary>
    /// Gets the source for where the mount is acquired.
    /// </summary>
    [JsonPropertyName("source")]
    public EnumType Source { get; init; }

    /// <summary>
    /// Gets the faction for the mount.
    /// </summary>
    [JsonPropertyName("faction")]
    public EnumType Faction { get; init; }

    /// <summary>
    /// Gets the requiements for using the mount.
    /// </summary>
    [JsonPropertyName("requirements")]
    public MountRequirements Requirements { get; init; }
}
