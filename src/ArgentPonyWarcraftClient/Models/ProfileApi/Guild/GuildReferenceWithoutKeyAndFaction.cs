using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a guild.
    /// </summary>
    public class GuildReferenceWithoutKeyAndFaction
    {
        /// <summary>
        /// Gets the name of the guild.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the guild.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets a reference to the realm to which the guild belongs.
        /// </summary>
        [JsonProperty("realm")]
        public RealmReferenceWithoutKey Realm { get; set; }
    }
}
