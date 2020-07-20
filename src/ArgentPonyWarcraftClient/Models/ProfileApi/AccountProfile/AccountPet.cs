using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A battle pet belonging to a World of Warcraft account.
    /// </summary>
    public class AccountPet
    {
        /// <summary>
        /// Gets a reference to the species of the pet.
        /// </summary>
        [JsonPropertyName("species")]
        public PetReference Species { get; set; }

        /// <summary>
        /// Gets the level of the pet.
        /// </summary>
        [JsonPropertyName("level")]
        public long Level { get; set; }

        /// <summary>
        /// Gets the quality of the pet.
        /// </summary>
        [JsonPropertyName("quality")]
        public EnumType Quality { get; set; }

        /// <summary>
        /// Gets the pet stats.
        /// </summary>
        [JsonPropertyName("stats")]
        public PetStats Stats { get; set; }

        /// <summary>
        /// Gets a reference to the creature display media for the pet.
        /// </summary>
        [JsonPropertyName("creature_display")]
        public CreatureDisplayMediaReference CreatureDisplay { get; set; }

        /// <summary>
        /// Gets the ID of the pet.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets a value indicating whether the pet is a favorite.
        /// </summary>
        [JsonPropertyName("is_favorite")]
        public bool? IsFavorite { get; set; }

        /// <summary>
        /// Gets a value indicating whether the pet is currently active.
        /// </summary>
        [JsonPropertyName("is_active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets the slot number if the pet is currently active.
        /// </summary>
        [JsonPropertyName("active_slot")]
        public long? ActiveSlot { get; set; }
    }
}
