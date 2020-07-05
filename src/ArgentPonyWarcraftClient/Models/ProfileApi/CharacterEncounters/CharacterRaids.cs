using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A summary of a character's completed raids.
    /// </summary>
    public class CharacterRaids
    {
        /// <summary>
        /// Gets links for the character's completed instances.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonProperty("character")]
        public CharacterReference Character { get; set; }

        /// <summary>
        /// Gets the character's completed instances, organized by game expansion.
        /// </summary>
        [JsonProperty("expansions")]
        public CharacterExpansionInstances[] Expansions { get; set; }
    }
}
