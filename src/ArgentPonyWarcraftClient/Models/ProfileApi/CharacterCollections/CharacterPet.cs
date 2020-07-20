using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A specific pet that has been collected by a character.
    /// </summary>
    public class CharacterPet
    {
        /// <summary>
        /// Gets a reference to the pet's species.
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
        /// Gets the stats for the pet.
        /// </summary>
        [JsonPropertyName("stats")]
        public PetStats Stats { get; set; }

        /// <summary>
        /// Gets the display information for the pet.
        /// </summary>
        [JsonPropertyName("creature_display")]
        public Media CreatureDisplay { get; set; }

        /// <summary>
        /// Gets the ID of the pet.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets a value indicating whether the pet has been selected as a favorite.
        /// </summary>
        [JsonPropertyName("is_favorite")]
        public bool? IsFavorite { get; set; }

        /// <summary>
        /// Gets a value indicating whether the pet is currently active.
        /// </summary>
        [JsonPropertyName("is_active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets the active slot, if any, for the pet.
        /// </summary>
        [JsonPropertyName("active_slot")]
        public long? ActiveSlot { get; set; }
    }
}
