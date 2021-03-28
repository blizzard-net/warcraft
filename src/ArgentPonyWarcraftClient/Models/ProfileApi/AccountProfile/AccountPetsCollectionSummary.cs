using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A summary of the battle pets an account has obtained.
    /// </summary>
    public record AccountPetsCollectionSummary
    {
        /// <summary>
        /// Gets links for the summary of the battle pets the account has obtained.
        /// </summary>
        [JsonPropertyName("_links")]
        public LinksForAccountProfile Links { get; }

        /// <summary>
        /// Gets the battle pets for the account.
        /// </summary>
        [JsonPropertyName("pets")]
        public AccountPet[] Pets { get; }

        /// <summary>
        /// Gets the number of battle pet slots the account has unlocked.
        /// </summary>
        [JsonPropertyName("unlocked_battle_pet_slots")]
        public int UnlockedBattlePetSlots { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountPetsCollectionSummary"/> class.
        /// </summary>
        /// <param name="links">Links for the summary of the battle pets the account has obtained.</param>
        /// <param name="pets">The battle pets for the account.</param>
        /// <param name="unlockedBattlePetSlots">The number of battle pet slots the account has unlocked.</param>
        [JsonConstructor]
        public AccountPetsCollectionSummary(LinksForAccountProfile links, AccountPet[] pets, int unlockedBattlePetSlots)
        {
            Links = links;
            Pets = pets;
            UnlockedBattlePetSlots = unlockedBattlePetSlots;
        }
    }
}
