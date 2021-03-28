using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of pet abilities.
    /// </summary>
    public record PetAbilitiesIndex
    {
        /// <summary>
        /// Gets links for the index of pet abilities.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to the pet abilities.
        /// </summary>
        [JsonPropertyName("abilities")]
        public PetAbilityReference[] Abilities { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PetAbilitiesIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of pet abilities.</param>
        /// <param name="abilities">References to the pet abilities.</param>
        [JsonConstructor]
        public PetAbilitiesIndex(Links links, PetAbilityReference[] abilities)
        {
            Links = links;
            Abilities = abilities;
        }
    }
}
