using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A guild roster.
    /// </summary>
    public class GuildRoster
    {
        /// <summary>
        /// Gets links for the guild roster.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a reference to the guild.
        /// </summary>
        [JsonPropertyName("guild")]
        public GuildReference Guild { get; set; }

        /// <summary>
        /// Gets the guild members.
        /// </summary>
        [JsonPropertyName("members")]
        public GuildMember[] Members { get; set; }
    }
}
