using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A guild perk.
    /// </summary>
    public class Perk
    {
        /// <summary>
        /// Gets or sets the guild level.
        /// </summary>
        [JsonProperty("guildLevel")]
        public int GuildLevel { get; set; }

        /// <summary>
        /// Gets or sets the spell.
        /// </summary>
        [JsonProperty("spell")]
        public Spell Spell { get; set; }
    }
}
