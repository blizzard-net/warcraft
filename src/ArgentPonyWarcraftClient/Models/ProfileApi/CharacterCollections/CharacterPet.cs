using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A specific pet that has been collected by a character.
    /// </summary>
    public record CharacterPet
    {
        /// <summary>
        /// Gets a reference to the pet's species.
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
        /// Gets the stats for the pet.
        /// </summary>
        [JsonPropertyName("stats")]
        public PetStats Stats { get; }

        /// <summary>
        /// Gets the display information for the pet.
        /// </summary>
        [JsonPropertyName("creature_display")]
        public Media CreatureDisplay { get; }

        /// <summary>
        /// Gets the ID of the pet.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets a value indicating whether the pet has been selected as a favorite.
        /// </summary>
        [JsonPropertyName("is_favorite")]
        public bool? IsFavorite { get; }

        /// <summary>
        /// Gets a value indicating whether the pet is currently active.
        /// </summary>
        [JsonPropertyName("is_active")]
        public bool? IsActive { get; }

        /// <summary>
        /// Gets the active slot, if any, for the pet.
        /// </summary>
        [JsonPropertyName("active_slot")]
        public int? ActiveSlot { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterPet"/> class.
        /// </summary>
        /// <param name="species">A reference to the pet's species.</param>
        /// <param name="level">The level of the pet.</param>
        /// <param name="quality">The quality of the pet.</param>
        /// <param name="stats">The stats for the pet.</param>
        /// <param name="creatureDisplay">The display information for the pet.</param>
        /// <param name="id">The ID of the pet.</param>
        /// <param name="isFavorite">A value indicating whether the pet has been selected as a favorite.</param>
        /// <param name="isActive">A value indicating whether the pet is currently active.</param>
        /// <param name="activeSlot">The active slot, if any, for the pet.</param>
        [JsonConstructor]
        public CharacterPet(PetReference species, int level, EnumType quality, PetStats stats, Media creatureDisplay, int id, bool? isFavorite, bool? isActive, int? activeSlot)
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
