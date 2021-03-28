using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A pet ability for a specific pet species.
    /// </summary>
    public record SpeciesPetAbility
    {
        /// <summary>
        /// Gets a reference to the pet ability.
        /// </summary>
        [JsonPropertyName("ability")]
        public PetAbilityReference Ability { get; }

        /// <summary>
        /// Gets the slot number for the pet ability.
        /// </summary>
        [JsonPropertyName("slot")]
        public int Slot { get; }

        /// <summary>
        /// Gets the required pet level to use the pet ability.
        /// </summary>
        [JsonPropertyName("required_level")]
        public int RequiredLevel { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeciesPetAbility"/> class.
        /// </summary>
        /// <param name="ability">A reference to the pet ability.</param>
        /// <param name="slot">The slot number for the pet ability.</param>
        /// <param name="requiredLevel">The required pet level to use the pet ability.</param>
        [JsonConstructor]
        public SpeciesPetAbility(PetAbilityReference ability, int slot, int requiredLevel)
        {
            Ability = ability;
            Slot = slot;
            RequiredLevel = requiredLevel;
        }
    }
}
