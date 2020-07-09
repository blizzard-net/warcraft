using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a reference to the guild.
        /// </summary>
        [JsonProperty("guild")]
        public GuildReference Guild { get; set; }

        /// <summary>
        /// Gets the guild members.
        /// </summary>
        [JsonProperty("members")]
        public GuildMember[] Members { get; set; }
    }
}
