using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A guild's activity.
    /// </summary>
    public record GuildActivity
    {
        /// <summary>
        /// Gets links for the guild's activity.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a reference to the guild.
        /// </summary>
        [JsonPropertyName("guild")]
        public GuildReference Guild { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuildActivity"/> class.
        /// </summary>
        /// <param name="links">Links for the guild's activity.</param>
        /// <param name="guild">A reference to the guild.</param>
        [JsonConstructor]
        public GuildActivity(Links links, GuildReference guild)
        {
            Links = links;
            Guild = guild;
        }
    }
}
