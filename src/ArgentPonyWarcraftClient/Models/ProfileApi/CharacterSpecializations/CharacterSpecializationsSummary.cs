using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A summary of a character's specializations.
    /// </summary>
    public record CharacterSpecializationsSummary
    {
        /// <summary>
        /// Gets links for the summary of the character's specializations.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the character's specializations.
        /// </summary>
        [JsonPropertyName("specializations")]
        public CharacterSpecialization[] Specializations { get; }

        /// <summary>
        /// Gets the character's active specialization.
        /// </summary>
        [JsonPropertyName("active_specialization")]
        public PlayableSpecializationReference ActiveSpecialization { get; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonPropertyName("character")]
        public CharacterReference Character { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterSpecializationsSummary"/> class.
        /// </summary>
        /// <param name="links">Links for the summary of the character's specializations.</param>
        /// <param name="specializations">The character's specializations.</param>
        /// <param name="activeSpecialization">The character's active specialization.</param>
        /// <param name="character">A reference to the character.</param>
        [JsonConstructor]
        public CharacterSpecializationsSummary(Links links, CharacterSpecialization[] specializations, PlayableSpecializationReference activeSpecialization, CharacterReference character)
        {
            Links = links;
            Specializations = specializations;
            ActiveSpecialization = activeSpecialization;
            Character = character;
        }
    }
}
