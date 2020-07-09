using Newtonsoft.Json;

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
        [JsonProperty("character")]
        public GuildCharacter Character { get; set; }

        /// <summary>
        /// Gets the character's rank in the guild.
        /// </summary>
        [JsonProperty("rank")]
        public long Rank { get; set; }
    }
}
