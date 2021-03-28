using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// The Mythic Keystone profile index for a character.
    /// </summary>
    public record CharacterMythicKeystoneProfileIndex
    {
        /// <summary>
        /// Gets links for the Mythic Keystone profile index.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the current Mythic Keystone period.
        /// </summary>
        [JsonPropertyName("current_period")]
        public CurrentPeriod CurrentPeriod { get; }

        /// <summary>
        /// Gets references to the Mythic Keystone season details for the character.
        /// </summary>
        [JsonPropertyName("seasons")]
        public CharacterMythicKeystoneSeasonDetailsReference[] Seasons { get; }

        /// <summary>
        /// Gets the character details.
        /// </summary>
        [JsonPropertyName("character")]
        public CharacterReference Character { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterMythicKeystoneProfileIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the Mythic Keystone profile index.</param>
        /// <param name="currentPeriod">The current Mythic Keystone period.</param>
        /// <param name="seasons">References to the Mythic Keystone season details for the character.</param>
        /// <param name="character">The character details.</param>
        [JsonConstructor]
        public CharacterMythicKeystoneProfileIndex(Links links, CurrentPeriod currentPeriod, CharacterMythicKeystoneSeasonDetailsReference[] seasons, CharacterReference character)
        {
            Links = links;
            CurrentPeriod = currentPeriod;
            Seasons = seasons;
            Character = character;
        }
    }
}
