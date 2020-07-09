using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A guild's activity.
    /// </summary>
    public class GuildActivity
    {
        /// <summary>
        /// Gets links for the guild's activity.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a reference to the guild.
        /// </summary>
        [JsonProperty("guild")]
        public GuildReference Guild { get; set; }
    }
}
