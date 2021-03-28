using System.Text.Json.Serialization;

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
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the pet abilities.
        /// </summary>
        [JsonPropertyName("abilities")]
        public PetAbilityReference[] Abilities { get; set; }
    }
}
