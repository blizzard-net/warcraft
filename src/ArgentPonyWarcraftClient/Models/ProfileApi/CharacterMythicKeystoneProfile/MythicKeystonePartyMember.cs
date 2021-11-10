namespace ArgentPonyWarcraftClient;

/// <summary>
/// A party member for a Mythic Keystone dungeon.
/// </summary>
public record MythicKeystonePartyMember
{
    /// <summary>
    /// Gets details about the character.
    /// </summary>
    [JsonPropertyName("character")]
    public MemberCharacter Character { get; init; }

    /// <summary>
    /// Gets a reference to the specialization of the character.
    /// </summary>
    [JsonPropertyName("specialization")]
    public PlayableSpecializationReference Specialization { get; init; }

    /// <summary>
    /// Gets a reference to the race of the character.
    /// </summary>
    [JsonPropertyName("race")]
    public PlayableRaceReference Race { get; init; }

    /// <summary>
    /// Gets the equipped item level of the character.
    /// </summary>
    [JsonPropertyName("equipped_item_level")]
    public int EquippedItemLevel { get; init; }
}
