using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A battle pet belonging to a World of Warcraft account.
    /// </summary>
    public record AccountPet
    {
        /// <summary>
        /// Gets a reference to the species of the pet.
        /// </summary>
        [JsonPropertyName("species")]
        public PetReference Species { get; }

        /// <summary>
        /// Gets the level of the pet.
        /// </summary>
        [JsonPropertyName("level")]
        public int Level { get; }

        /// <summary>
        /// Gets the quality of the pet.
        /// </summary>
        [JsonPropertyName("quality")]
        public EnumType Quality { get; }

        /// <summary>
        /// Gets the pet stats.
        /// </summary>
        [JsonPropertyName("stats")]
        public PetStats Stats { get; }

        /// <summary>
        /// Gets a reference to the creature display media for the pet.
        /// </summary>
        [JsonPropertyName("creature_display")]
        public CreatureDisplayMediaReference CreatureDisplay { get; }

        /// <summary>
        /// Gets the ID of the pet.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets a value indicating whether the pet is a favorite.
        /// </summary>
        [JsonPropertyName("is_favorite")]
        public bool? IsFavorite { get; }

        /// <summary>
        /// Gets a value indicating whether the pet is currently active.
        /// </summary>
        [JsonPropertyName("is_active")]
        public bool? IsActive { get; }

        /// <summary>
        /// Gets the slot number if the pet is currently active.
        /// </summary>
        [JsonPropertyName("active_slot")]
        public int? ActiveSlot { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountPet"/> class.
        /// </summary>
        /// <param name="species">A reference to the species of the pet.</param>
        /// <param name="level">The level of the pet.</param>
        /// <param name="quality">The quality of the pet.</param>
        /// <param name="stats">The pet stats.</param>
        /// <param name="creatureDisplay">A reference to the creature display media for the pet.</param>
        /// <param name="id">The ID of the pet.</param>
        /// <param name="isFavorite">A value indicating whether the pet is a favorite.</param>
        /// <param name="isActive">A value indicating whether the pet is currently active.</param>
        /// <param name="activeSlot">The slot number if the pet is currently active.</param>
        [JsonConstructor]
        public AccountPet(PetReference species, int level, EnumType quality, PetStats stats, CreatureDisplayMediaReference creatureDisplay, int id, bool? isFavorite, bool? isActive, int? activeSlot)
        {
            Species = species;
            Level = level;
            Quality = quality;
            Stats = stats;
            CreatureDisplay = creatureDisplay;
            Id = id;
            IsFavorite = isFavorite;
            IsActive = isActive;
            ActiveSlot = activeSlot;
        }
    }
}
