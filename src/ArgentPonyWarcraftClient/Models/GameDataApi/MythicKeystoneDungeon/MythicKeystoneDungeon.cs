namespace ArgentPonyWarcraftClient;

/// <summary>
/// A mythic keystone dungeon.
/// </summary>
public record MythicKeystoneDungeon
{
    /// <summary>
    /// Gets links for the mythic keystone dungeon.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of the mythic keystone dungeon.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the name of the mythic keystone dungeon.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the map of the mythic keystone dungeon.
    /// </summary>
    [JsonPropertyName("map")]
    public Map Map { get; init; }

    /// <summary>
    /// Gets the zone for the mythic keystone dungeon.
    /// </summary>
    [JsonPropertyName("zone")]
    public ZoneReferenceSlug Zone { get; init; }

    /// <summary>
    /// Gets a reference to the dungeon instance.
    /// </summary>
    [JsonPropertyName("dungeon")]
    public InstanceReference Dungeon { get; init; }

    /// <summary>
    /// Gets the keystone upgrades for the mythic keystone dungeon.
    /// </summary>
    [JsonPropertyName("keystone_upgrades")]
    public MythicKeystoneUpgrade[] KeystoneUpgrades { get; init; }

    /// <summary>
    /// Gets a value indicating whether the mythic keystone dungeon is tracked.
    /// </summary>
    [JsonPropertyName("is_tracked")]
    public bool IsTracked { get; init; }
}
