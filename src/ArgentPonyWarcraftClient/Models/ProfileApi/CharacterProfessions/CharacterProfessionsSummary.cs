using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A summary of professions for a character.
    /// </summary>
    public class CharacterProfessionsSummary
    {
        /// <summary>
        /// Gets links for the character professions summary.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the character's primary professions.
        /// </summary>
        [JsonProperty("primaries")]
        public CharacterProfession[] Primaries { get; set; }

        /// <summary>
        /// Gets the character's secondary professions.
        /// </summary>
        [JsonProperty("secondaries")]
        public CharacterProfession[] Secondaries { get; set; }
    }
}
