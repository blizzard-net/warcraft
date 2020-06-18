using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A pet ability for a specific pet species.
    /// </summary>
    public class SpeciesPetAbility
    {
        /// <summary>
        /// Gets a reference to the pet ability.
        /// </summary>
        [JsonProperty("ability")]
        public PetAbilityReference Ability { get; set; }

        /// <summary>
        /// Gets the slot number for the pet ability.
        /// </summary>
        [JsonProperty("slot")]
        public long Slot { get; set; }

        /// <summary>
        /// Gets the required pet level to use the pet ability.
        /// </summary>
        [JsonProperty("required_level")]
        public long RequiredLevel { get; set; }
    }
}
