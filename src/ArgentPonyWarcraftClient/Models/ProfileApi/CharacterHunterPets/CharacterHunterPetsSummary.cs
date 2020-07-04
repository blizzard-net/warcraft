using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonProperty("character")]
        public CharacterReference Character { get; set; }

        /// <summary>
        /// Gets the character's hunter pets.
        /// </summary>
        [JsonProperty("hunter_pets")]
        public HunterPet[] HunterPets { get; set; }
    }
}
