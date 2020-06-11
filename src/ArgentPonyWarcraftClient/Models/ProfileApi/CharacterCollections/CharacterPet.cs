using Newtonsoft.Json;

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
        [JsonProperty("species")]
        public PetReference Species { get; set; }

        /// <summary>
        /// Gets the level of the pet.
        /// </summary>
        [JsonProperty("level")]
        public long Level { get; set; }

        /// <summary>
        /// Gets the quality of the pet.
        /// </summary>
        [JsonProperty("quality")]
        public EnumType Quality { get; set; }

        /// <summary>
        /// Gets the stats for the pet.
        /// </summary>
        [JsonProperty("stats")]
        public PetStats Stats { get; set; }

        /// <summary>
        /// Gets the display information for the pet.
        /// </summary>
        [JsonProperty("creature_display", NullValueHandling = NullValueHandling.Ignore)]
        public Media CreatureDisplay { get; set; }

        /// <summary>
        /// Gets the ID of the pet.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets a value indicating whether the pet has been selected as a favorite.
        /// </summary>
        [JsonProperty("is_favorite", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFavorite { get; set; }

        /// <summary>
        /// Gets a value indicating whether the pet is currently active.
        /// </summary>
        [JsonProperty("is_active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets the active slot, if any, for the pet.
        /// </summary>
        [JsonProperty("active_slot", NullValueHandling = NullValueHandling.Ignore)]
        public long? ActiveSlot { get; set; }
    }
}
