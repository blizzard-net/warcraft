using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A summary of the battle pets a character has obtained.
    /// </summary>
    public record CharacterPetsCollectionSummary
    {
        /// <summary>
        /// Gets links for the character pets collection summary.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the pets this character has collected.
        /// </summary>
        [JsonPropertyName("pets")]
        public CharacterPet[] Pets { get; }

        /// <summary>
        /// Gets the number of unlocked battle pet slots for this character.
        /// </summary>
        [JsonPropertyName("unlocked_battle_pet_slots")]
        public int UnlockedBattlePetSlots { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterPetsCollectionSummary"/> class.
        /// </summary>
        /// <param name="links">Links for the character pets collection summary.</param>
        /// <param name="pets">The pets this character has collected.</param>
        /// <param name="unlockedBattlePetSlots">The number of unlocked battle pet slots for this character.</param>
        [JsonConstructor]
        public CharacterPetsCollectionSummary(Links links, CharacterPet[] pets, int unlockedBattlePetSlots)
        {
            Links = links;
            Pets = pets;
            UnlockedBattlePetSlots = unlockedBattlePetSlots;
        }
    }
}
