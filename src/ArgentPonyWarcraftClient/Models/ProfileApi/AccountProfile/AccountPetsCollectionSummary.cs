using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A summary of the battle pets an account has obtained.
    /// </summary>
    public class AccountPetsCollectionSummary
    {
        /// <summary>
        /// Gets links for the summary of the battle pets the account has obtained.
        /// </summary>
        [JsonPropertyName("_links")]
        public LinksForAccountProfile Links { get; set; }

        /// <summary>
        /// Gets the battle pets for the account.
        /// </summary>
        [JsonPropertyName("pets")]
        public AccountPet[] Pets { get; set; }

        /// <summary>
        /// Gets the number of battle pet slots the account has unlocked.
        /// </summary>
        [JsonPropertyName("unlocked_battle_pet_slots")]
        public long UnlockedBattlePetSlots { get; set; }
    }
}
