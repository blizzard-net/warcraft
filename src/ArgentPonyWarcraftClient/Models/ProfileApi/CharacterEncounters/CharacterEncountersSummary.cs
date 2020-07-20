using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A summary of a character's encounters.
    /// </summary>
    public class CharacterEncountersSummary
    {
        /// <summary>
        /// Gets links for the character encounters summary.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonPropertyName("character")]
        public CharacterReference Character { get; set; }

        /// <summary>
        /// Gets a link to the character's dungeon encounters.
        /// </summary>
        [JsonPropertyName("dungeons")]
        public Self Dungeons { get; set; }

        /// <summary>
        /// Gets a link to the character's raid encounters.
        /// </summary>
        [JsonPropertyName("raids")]
        public Self Raids { get; set; }
    }
}
