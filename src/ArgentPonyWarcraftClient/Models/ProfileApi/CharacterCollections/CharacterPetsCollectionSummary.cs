namespace ArgentPonyWarcraftClient;

/// <summary>
/// A summary of the battle pets a character has obtained.
/// </summary>
public record CharacterPetsCollectionSummary
{
    /// <summary>
    /// Gets links for the character pets collection summary.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the pets this character has collected.
    /// </summary>
    [JsonPropertyName("pets")]
    public CharacterPet[] Pets { get; init; }

    /// <summary>
    /// Gets the number of unlocked battle pet slots for this character.
    /// </summary>
    [JsonPropertyName("unlocked_battle_pet_slots")]
    public int UnlockedBattlePetSlots { get; init; }
}
