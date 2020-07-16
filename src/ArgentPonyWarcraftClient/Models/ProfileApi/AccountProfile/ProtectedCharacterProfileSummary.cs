using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A protected profile summary for a character.
    /// </summary>
    public class ProtectedCharacterProfileSummary
    {
        /// <summary>
        /// Gets links for the protected profile summary for the character.
        /// </summary>
        [JsonProperty("_links")]
        public LinksForAccountProfile Links { get; set; }

        /// <summary>
        /// Gets the ID of the character.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the character.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the amount of money owned by the character.
        /// </summary>
        [JsonProperty("money")]
        public long Money { get; set; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonProperty("character")]
        public CharacterReference Character { get; set; }

        /// <summary>
        /// Gets the protected statistics for the character.
        /// </summary>
        [JsonProperty("protected_stats")]
        public ProtectedStats ProtectedStats { get; set; }

        /// <summary>
        /// Gets the character's current position.
        /// </summary>
        [JsonProperty("position")]
        public Position Position { get; set; }

        /// <summary>
        /// Gets the bind position of the character's hearthstone.
        /// </summary>
        [JsonProperty("bind_position")]
        public Position BindPosition { get; set; }

        /// <summary>
        /// Gets the WoW account for the character.
        /// </summary>
        [JsonProperty("wow_account")]
        public long WowAccount { get; set; }
    }
}
