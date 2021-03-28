using System.Text.Json.Serialization;

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
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the character's specializations.
        /// </summary>
        [JsonPropertyName("specializations")]
        public CharacterSpecialization[] Specializations { get; set; }

        /// <summary>
        /// Gets the character's active specialization.
        /// </summary>
        [JsonPropertyName("active_specialization")]
        public PlayableSpecializationReference ActiveSpecialization { get; set; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonPropertyName("character")]
        public CharacterReference Character { get; set; }
    }
}
