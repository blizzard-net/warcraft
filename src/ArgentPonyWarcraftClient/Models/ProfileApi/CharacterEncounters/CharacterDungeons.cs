using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A summary of a character's completed dungeons.
    /// </summary>
    public class CharacterDungeons
    {
        /// <summary>
        /// Gets links for the character's completed instances.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the character's completed instances, organized by game expansion.
        /// </summary>
        [JsonPropertyName("expansions")]
        public CharacterExpansionInstances[] Expansions { get; set; }
    }
}
