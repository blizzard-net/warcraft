using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A summary of a character's completed dungeons.
    /// </summary>
    public record CharacterDungeons
    {
        /// <summary>
        /// Gets links for the character's completed instances.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the character's completed instances, organized by game expansion.
        /// </summary>
        [JsonPropertyName("expansions")]
        public CharacterExpansionInstances[] Expansions { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterDungeons"/> class.
        /// </summary>
        /// <param name="links">Links for the character's completed instances.</param>
        /// <param name="expansions">The character's completed instances, organized by game expansion.</param>
        [JsonConstructor]
        public CharacterDungeons(Links links, CharacterExpansionInstances[] expansions)
        {
            Links = links;
            Expansions = expansions;
        }
    }
}
