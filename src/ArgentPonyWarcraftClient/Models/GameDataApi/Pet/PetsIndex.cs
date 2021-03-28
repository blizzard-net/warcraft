using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of pets.
    /// </summary>
    public record PetsIndex
    {
        /// <summary>
        /// Gets links for the index of pets.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to pets.
        /// </summary>
        [JsonPropertyName("pets")]
        public PetReference[] Pets { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PetsIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of pets.</param>
        /// <param name="pets">References to pets.</param>
        [JsonConstructor]
        public PetsIndex(Links links, PetReference[] pets)
        {
            Links = links;
            Pets = pets;
        }
    }
}
