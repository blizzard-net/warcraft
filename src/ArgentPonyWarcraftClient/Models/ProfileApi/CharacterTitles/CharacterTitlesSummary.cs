using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonProperty("character")]
        public CharacterReference Character { get; set; }

        /// <summary>
        /// Gets the character's active title.
        /// </summary>
        [JsonProperty("active_title")]
        public TitleReferenceWithDisplayString ActiveTitle { get; set; }

        /// <summary>
        /// Gets references to the titles the character has obtained.
        /// </summary>
        [JsonProperty("titles")]
        public TitleReference[] Titles { get; set; }
    }
}
