using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of character collections.
    /// </summary>
    public record CharacterCollectionsIndex
    {
        /// <summary>
        /// Gets links for the character collections index.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a reference to the character's collection of pets.
        /// </summary>
        [JsonPropertyName("pets")]
        public Self Pets { get; }

        /// <summary>
        /// Gets a reference to the character's collection of mounts.
        /// </summary>
        [JsonPropertyName("mounts")]
        public Self Mounts { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterCollectionsIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the character collections index.</param>
        /// <param name="pets">A reference to the character's collection of pets.</param>
        /// <param name="mounts">A reference to the character's collection of mounts.</param>
        [JsonConstructor]
        public CharacterCollectionsIndex(Links links, Self pets, Self mounts)
        {
            Links = links;
            Pets = pets;
            Mounts = mounts;
        }
    }
}
