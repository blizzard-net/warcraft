using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A summary of a character's encounters.
    /// </summary>
    public record CharacterEncountersSummary
    {
        /// <summary>
        /// Gets links for the character encounters summary.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonPropertyName("character")]
        public CharacterReference Character { get; }

        /// <summary>
        /// Gets a link to the character's dungeon encounters.
        /// </summary>
        [JsonPropertyName("dungeons")]
        public Self Dungeons { get; }

        /// <summary>
        /// Gets a link to the character's raid encounters.
        /// </summary>
        [JsonPropertyName("raids")]
        public Self Raids { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterEncountersSummary"/> class.
        /// </summary>
        /// <param name="links">Links for the character encounters summary.</param>
        /// <param name="character">A reference to the character.</param>
        /// <param name="dungeons">A link to the character's dungeon encounters.</param>
        /// <param name="raids">A link to the character's raid encounters.</param>
        [JsonConstructor]
        public CharacterEncountersSummary(Links links, CharacterReference character, Self dungeons, Self raids)
        {
            Links = links;
            Character = character;
            Dungeons = dungeons;
            Raids = raids;
        }
    }
}
