using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A World of Warcraft account.
    /// </summary>
    public record WowAccount
    {
        /// <summary>
        /// Gets the ID of the World of Warcraft account.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the characters associated with the World of Warcraft account.
        /// </summary>
        [JsonPropertyName("characters")]
        public AccountCharacter[] Characters { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WowAccount"/> class.
        /// </summary>
        /// <param name="id">The ID of the World of Warcraft account.</param>
        /// <param name="characters">The characters associated with the World of Warcraft account.</param>
        [JsonConstructor]
        public WowAccount(int id, AccountCharacter[] characters)
        {
            Id = id;
            Characters = characters;
        }
    }
}
