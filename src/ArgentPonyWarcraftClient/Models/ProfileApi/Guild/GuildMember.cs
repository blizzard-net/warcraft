using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A guild member.
    /// </summary>
    public class GuildMember
    {
        /// <summary>
        /// Gets the character.
        /// </summary>
        [JsonPropertyName("character")]
        public GuildCharacter Character { get; set; }

        /// <summary>
        /// Gets the character's rank in the guild.
        /// </summary>
        [JsonPropertyName("rank")]
        public int Rank { get; set; }
    }
}
