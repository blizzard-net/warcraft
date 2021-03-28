using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A summary of professions for a character.
    /// </summary>
    public record CharacterProfessionsSummary
    {
        /// <summary>
        /// Gets links for the character professions summary.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the character's primary professions.
        /// </summary>
        [JsonPropertyName("primaries")]
        public CharacterProfession[] Primaries { get; }

        /// <summary>
        /// Gets the character's secondary professions.
        /// </summary>
        [JsonPropertyName("secondaries")]
        public CharacterProfession[] Secondaries { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterProfessionsSummary"/> class.
        /// </summary>
        /// <param name="links">Links for the character professions summary.</param>
        /// <param name="primaries">The character's primary professions.</param>
        /// <param name="secondaries">The character's secondary professions.</param>
        [JsonConstructor]
        public CharacterProfessionsSummary(Links links, CharacterProfession[] primaries, CharacterProfession[] secondaries)
        {
            Links = links;
            Primaries = primaries;
            Secondaries = secondaries;
        }
    }
}
