using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of playable specializations.
    /// </summary>
    public record PlayableSpecializationsIndex
    {
        /// <summary>
        /// Gets links for the index of playable specializations.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to the character specializations.
        /// </summary>
        [JsonPropertyName("character_specializations")]
        public PlayableSpecializationReference[] CharacterSpecializations { get; }

        /// <summary>
        /// Gets references to the pet specializations.
        /// </summary>
        [JsonPropertyName("pet_specializations")]
        public PlayableSpecializationReference[] PetSpecializations { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayableSpecializationsIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of playable specializations.</param>
        /// <param name="characterSpecializations">References to the character specializations.</param>
        /// <param name="petSpecializations">References to the pet specializations.</param>
        [JsonConstructor]
        public PlayableSpecializationsIndex(Links links, PlayableSpecializationReference[] characterSpecializations, PlayableSpecializationReference[] petSpecializations)
        {
            Links = links;
            CharacterSpecializations = characterSpecializations;
            PetSpecializations = petSpecializations;
        }
    }
}
