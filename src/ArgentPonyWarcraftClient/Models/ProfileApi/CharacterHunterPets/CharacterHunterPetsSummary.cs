using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A summary of the character's hunter pets.
    /// </summary>
    public record CharacterHunterPetsSummary
    {
        /// <summary>
        /// Gets links for the character hunter pets summary.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonPropertyName("character")]
        public CharacterReference Character { get; }

        /// <summary>
        /// Gets the character's hunter pets.
        /// </summary>
        [JsonPropertyName("hunter_pets")]
        public HunterPet[] HunterPets { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterHunterPetsSummary"/> class.
        /// </summary>
        /// <param name="links">Links for the character hunter pets summary.</param>
        /// <param name="character">A reference to the character.</param>
        /// <param name="hunterPets">The character's hunter pets.</param>
        [JsonConstructor]
        public CharacterHunterPetsSummary(Links links, CharacterReference character, HunterPet[] hunterPets)
        {
            Links = links;
            Character = character;
            HunterPets = hunterPets;
        }
    }
}
