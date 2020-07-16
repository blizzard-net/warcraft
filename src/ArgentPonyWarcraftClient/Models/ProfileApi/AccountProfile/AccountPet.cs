namespace ArgentPonyWarcraftClient
{
    using Newtonsoft.Json;

    /// <summary>
    /// A battle pet belonging to a World of Warcraft account.
    /// </summary>
    public class AccountPet
    {
        /// <summary>
        /// Gets a reference to the species of the pet.
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
        /// Gets the pet stats.
        /// </summary>
        [JsonProperty("stats")]
        public PetStats Stats { get; set; }

        /// <summary>
        /// Gets a reference to the creature display media for the pet.
        /// </summary>
        [JsonProperty("creature_display", NullValueHandling = NullValueHandling.Ignore)]
        public CreatureDisplayMediaReference CreatureDisplay { get; set; }

        /// <summary>
        /// Gets the ID of the pet.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets a value indicating whether the pet is a favorite.
        /// </summary>
        [JsonProperty("is_favorite", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFavorite { get; set; }

        /// <summary>
        /// Gets a value indicating whether the pet is currently active.
        /// </summary>
        [JsonProperty("is_active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets the slot number if the pet is currently active.
        /// </summary>
        [JsonProperty("active_slot", NullValueHandling = NullValueHandling.Ignore)]
        public long? ActiveSlot { get; set; }
    }
}
