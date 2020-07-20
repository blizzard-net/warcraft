using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A summary of the character's hunter pets.
    /// </summary>
    public class CharacterHunterPetsSummary
    {
        /// <summary>
        /// Gets links for the character hunter pets summary.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonPropertyName("character")]
        public CharacterReference Character { get; set; }

        /// <summary>
        /// Gets the character's hunter pets.
        /// </summary>
        [JsonPropertyName("hunter_pets")]
        public HunterPet[] HunterPets { get; set; }
    }
}
