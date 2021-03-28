using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A guild member.
    /// </summary>
    public record GuildMember
    {
        /// <summary>
        /// Gets the character.
        /// </summary>
        [JsonPropertyName("character")]
        public GuildCharacter Character { get; }

        /// <summary>
        /// Gets the character's rank in the guild.
        /// </summary>
        [JsonPropertyName("rank")]
        public int Rank { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuildMember"/> class.
        /// </summary>
        /// <param name="character">The character.</param>
        /// <param name="rank">The character's rank in the guild.</param>
        [JsonConstructor]
        public GuildMember(GuildCharacter character, int rank)
        {
            Character = character;
            Rank = rank;
        }
    }
}
