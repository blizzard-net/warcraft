namespace ArgentPonyWarcraftClient;

/// <summary>
/// A summary of the battle pets an account has obtained.
/// </summary>
public record AccountPetsCollectionSummary
{
    /// <summary>
    /// Gets links for the summary of the battle pets the account has obtained.
    /// </summary>
    [JsonPropertyName("_links")]
    public LinksForAccountProfile Links { get; init; }

    /// <summary>
    /// Gets the battle pets for the account.
    /// </summary>
    [JsonPropertyName("pets")]
    public AccountPet[] Pets { get; init; }

    /// <summary>
    /// Gets the number of battle pet slots the account has unlocked.
    /// </summary>
    [JsonPropertyName("unlocked_battle_pet_slots")]
    public int UnlockedBattlePetSlots { get; init; }
}
