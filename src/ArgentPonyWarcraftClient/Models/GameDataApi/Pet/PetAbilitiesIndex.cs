using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of pet abilities.
    /// </summary>
    public class PetAbilitiesIndex
    {
        /// <summary>
        /// Gets links for the index of pet abilities.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the pet abilities.
        /// </summary>
        [JsonProperty("abilities")]
        public PetAbilityReference[] Abilities { get; set; }
    }
}
