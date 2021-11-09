namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a Mythic Keystone dungeon.
/// </summary>
public record MythicKeystoneDungeonReference
{
    /// <summary>
    /// Gets the key for the Mythic Keystone dungeon.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the Mythic Keystone dungeon.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the Mythic Keystone dungeon.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
