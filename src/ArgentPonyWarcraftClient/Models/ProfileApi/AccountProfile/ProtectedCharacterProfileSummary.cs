using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A protected profile summary for a character.
    /// </summary>
    public record ProtectedCharacterProfileSummary
    {
        /// <summary>
        /// Gets links for the protected profile summary for the character.
        /// </summary>
        [JsonPropertyName("_links")]
        public LinksForAccountProfile Links { get; }

        /// <summary>
        /// Gets the ID of the character.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of the character.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the amount of money owned by the character.
        /// </summary>
        [JsonPropertyName("money")]
        public long Money { get; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonPropertyName("character")]
        public CharacterReference Character { get; }

        /// <summary>
        /// Gets the protected statistics for the character.
        /// </summary>
        [JsonPropertyName("protected_stats")]
        public ProtectedStats ProtectedStats { get; }

        /// <summary>
        /// Gets the character's current position.
        /// </summary>
        [JsonPropertyName("position")]
        public Position Position { get; }

        /// <summary>
        /// Gets the bind position of the character's hearthstone.
        /// </summary>
        [JsonPropertyName("bind_position")]
        public Position BindPosition { get; }

        /// <summary>
        /// Gets the WoW account for the character.
        /// </summary>
        [JsonPropertyName("wow_account")]
        public int WowAccount { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedCharacterProfileSummary"/> class.
        /// </summary>
        /// <param name="links">Links for the protected profile summary for the character.</param>
        /// <param name="id">The ID of the character.</param>
        /// <param name="name">The name of the character.</param>
        /// <param name="money">The amount of money owned by the character.</param>
        /// <param name="character">A reference to the character.</param>
        /// <param name="protectedStats">The protected statistics for the character.</param>
        /// <param name="position">The character's current position.</param>
        /// <param name="bindPosition">The bind position of the character's hearthstone.</param>
        /// <param name="wowAccount">The WoW account for the character.</param>
        [JsonConstructor]
        public ProtectedCharacterProfileSummary(LinksForAccountProfile links, int id, string name, long money, CharacterReference character, ProtectedStats protectedStats, Position position, Position bindPosition, int wowAccount)
        {
            Links = links;
            Id = id;
            Name = name;
            Money = money;
            Character = character;
            ProtectedStats = protectedStats;
            Position = position;
            BindPosition = bindPosition;
            WowAccount = wowAccount;
        }
    }
}
