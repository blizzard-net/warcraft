using Newtonsoft.Json;

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
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the characters associated with the World of Warcraft account.
        /// </summary>
        [JsonProperty("characters")]
        public AccountCharacter[] Characters { get; set; }
    }
}
