namespace ArgentPonyWarcraftClient;

/// <summary>
/// A covenant soulbind.
/// </summary>
public record Soulbind
{
    /// <summary>
    /// Gets the links for the soulbind.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the Id for this soulbind.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the name for this soulbind.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the reference to the covenant this soulbind belongs to.
    /// </summary>
    [JsonPropertyName("covenant")]
    public CovenantReference Covenant { get; init; }

    /// <summary>
    /// Gets the creature reference for this soulbind.
    /// </summary>
    [JsonPropertyName("creature")]
    public CreatureReference Creature { get; init; }

    /// <summary>
    /// Gets the follower for this soulbind.
    /// </summary>
    [JsonPropertyName("follower")]
    public SoulbindFollower Follower { get; init; }

    /// <summary>
    /// Gets the reference to the tech talent tree for this soulbind.
    /// </summary>
    [JsonPropertyName("talent_tree")]
    public TechTalentTreeReference TalentTree { get; init; }
}
