using System.Text.Json.Serialization;

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
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the character's primary professions.
        /// </summary>
        [JsonPropertyName("primaries")]
        public CharacterProfession[] Primaries { get; set; }

        /// <summary>
        /// Gets the character's secondary professions.
        /// </summary>
        [JsonPropertyName("secondaries")]
        public CharacterProfession[] Secondaries { get; set; }
    }
}
