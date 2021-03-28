using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A guild roster.
    /// </summary>
    public record GuildRoster
    {
        /// <summary>
        /// Gets links for the guild roster.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a reference to the guild.
        /// </summary>
        [JsonPropertyName("guild")]
        public GuildReference Guild { get; }

        /// <summary>
        /// Gets the guild members.
        /// </summary>
        [JsonPropertyName("members")]
        public GuildMember[] Members { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuildRoster"/> class.
        /// </summary>
        /// <param name="links">Links for the guild roster.</param>
        /// <param name="guild">A reference to the guild.</param>
        /// <param name="members">The guild members.</param>
        [JsonConstructor]
        public GuildRoster(Links links, GuildReference guild, GuildMember[] members)
        {
            Links = links;
            Guild = guild;
            Members = members;
        }
    }
}
