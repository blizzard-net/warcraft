using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A summary of titles a character has obtained.
    /// </summary>
    public class CharacterTitlesSummary
    {
        /// <summary>
        /// Gets links for the summary of titles a character has obtained.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonPropertyName("character")]
        public CharacterReference Character { get; set; }

        /// <summary>
        /// Gets the character's active title.
        /// </summary>
        [JsonPropertyName("active_title")]
        public TitleReferenceWithDisplayString ActiveTitle { get; set; }

        /// <summary>
        /// Gets references to the titles the character has obtained.
        /// </summary>
        [JsonPropertyName("titles")]
        public TitleReference[] Titles { get; set; }
    }
}
