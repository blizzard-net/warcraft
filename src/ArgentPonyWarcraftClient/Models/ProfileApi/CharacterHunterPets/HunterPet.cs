using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A hunter pet.
    /// </summary>
    public record HunterPet
    {
        /// <summary>
        /// Gets the name of the hunter pet.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the level of the hunter pet.
        /// </summary>
        [JsonPropertyName("level")]
        public int Level { get; }

        /// <summary>
        /// Gets a reference to the creature type of the hunter pet.
        /// </summary>
        [JsonPropertyName("creature")]
        public CreatureReference Creature { get; }

        /// <summary>
        /// Gets the slot to which the hunter pet is assigned.
        /// </summary>
        [JsonPropertyName("slot")]
        public int Slot { get; }

        /// <summary>
        /// Gets a value indicating whether the hunter pet is active.
        /// </summary>
        [JsonPropertyName("is_active")]
        public bool? IsActive { get; }

        /// <summary>
        /// Gets a reference to creature display media for the hunter pet.
        /// </summary>
        [JsonPropertyName("creature_display")]
        public CreatureDisplayMediaReference CreatureDisplay { get; }

        /// <summary>
        /// Gets a value indicating whether the hunter pet is summoned.
        /// </summary>
        [JsonPropertyName("is_summoned")]
        public bool? IsSummoned { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="HunterPet"/> class.
        /// </summary>
        /// <param name="name">The name of the hunter pet.</param>
        /// <param name="level">The level of the hunter pet.</param>
        /// <param name="creature">A reference to the creature type of the hunter pet.</param>
        /// <param name="slot">The slot to which the hunter pet is assigned.</param>
        /// <param name="isActive">A value indicating whether the hunter pet is active.</param>
        /// <param name="creatureDisplay">A reference to creature display media for the hunter pet.</param>
        /// <param name="isSummoned">A value indicating whether the hunter pet is summoned.</param>
        [JsonConstructor]
        public HunterPet(string name, int level, CreatureReference creature, int slot, bool? isActive, CreatureDisplayMediaReference creatureDisplay, bool? isSummoned)
        {
            Name = name;
            Level = level;
            Creature = creature;
            Slot = slot;
            IsActive = isActive;
            CreatureDisplay = creatureDisplay;
            IsSummoned = isSummoned;
        }
    }
}
