namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of mythic keystone dungeons.
/// </summary>
public record MythicKeystoneDungeonsIndex
{
    /// <summary>
    /// Gets links for the index of mythic keystone dungeons.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets references to the mythic keystone dungeons.
    /// </summary>
    [JsonPropertyName("dungeons")]
    public MythicKeystoneDungeonReference[] Dungeons { get; init; }
}
