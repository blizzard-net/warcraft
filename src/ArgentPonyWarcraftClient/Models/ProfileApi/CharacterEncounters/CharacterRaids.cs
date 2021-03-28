using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A summary of a character's completed raids.
    /// </summary>
    public record CharacterRaids
    {
        /// <summary>
        /// Gets links for the character's completed instances.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonPropertyName("character")]
        public CharacterReference Character { get; }

        /// <summary>
        /// Gets the character's completed instances, organized by game expansion.
        /// </summary>
        [JsonPropertyName("expansions")]
        public CharacterExpansionInstances[] Expansions { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterRaids"/> class.
        /// </summary>
        /// <param name="links">Links for the character's completed instances.</param>
        /// <param name="character">A reference to the character.</param>
        /// <param name="expansions">The character's completed instances, organized by game expansion.</param>
        [JsonConstructor]
        public CharacterRaids(Links links, CharacterReference character, CharacterExpansionInstances[] expansions)
        {
            Links = links;
            Character = character;
            Expansions = expansions;
        }
    }
}
