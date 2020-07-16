using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A summary of a character's specializations.
    /// </summary>
    public class CharacterSpecializationsSummary
    {
        /// <summary>
        /// Gets links for the summary of the character's specializations.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the character's specializations.
        /// </summary>
        [JsonProperty("specializations")]
        public CharacterSpecialization[] Specializations { get; set; }

        /// <summary>
        /// Gets the character's active specialization.
        /// </summary>
        [JsonProperty("active_specialization")]
        public PlayableSpecializationReference ActiveSpecialization { get; set; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonProperty("character")]
        public CharacterReference Character { get; set; }
    }
}
