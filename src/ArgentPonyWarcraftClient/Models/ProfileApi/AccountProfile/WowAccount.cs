using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A World of Warcraft account.
    /// </summary>
    public class WowAccount
    {
        /// <summary>
        /// Gets the ID of the World of Warcraft account.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the characters associated with the World of Warcraft account.
        /// </summary>
        [JsonPropertyName("characters")]
        public AccountCharacter[] Characters { get; set; }
    }
}
