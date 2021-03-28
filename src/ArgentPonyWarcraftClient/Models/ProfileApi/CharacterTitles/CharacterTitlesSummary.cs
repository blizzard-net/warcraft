using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A summary of titles a character has obtained.
    /// </summary>
    public record CharacterTitlesSummary
    {
        /// <summary>
        /// Gets links for the summary of titles a character has obtained.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonPropertyName("character")]
        public CharacterReference Character { get; }

        /// <summary>
        /// Gets the character's active title.
        /// </summary>
        [JsonPropertyName("active_title")]
        public TitleReferenceWithDisplayString ActiveTitle { get; }

        /// <summary>
        /// Gets references to the titles the character has obtained.
        /// </summary>
        [JsonPropertyName("titles")]
        public TitleReference[] Titles { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterTitlesSummary"/> class.
        /// </summary>
        /// <param name="links">Links for the summary of titles a character has obtained.</param>
        /// <param name="character">A reference to the character.</param>
        /// <param name="activeTitle">The character's active title.</param>
        /// <param name="titles">References to the titles the character has obtained.</param>
        [JsonConstructor]
        public CharacterTitlesSummary(Links links, CharacterReference character, TitleReferenceWithDisplayString activeTitle, TitleReference[] titles)
        {
            Links = links;
            Character = character;
            ActiveTitle = activeTitle;
            Titles = titles;
        }
    }
}
