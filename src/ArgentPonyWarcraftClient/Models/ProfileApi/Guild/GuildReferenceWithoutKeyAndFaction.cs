using System.Text.Json.Serialization;

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
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the guild.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets a reference to the realm to which the guild belongs.
        /// </summary>
        [JsonPropertyName("realm")]
        public RealmReferenceWithoutKey Realm { get; set; }
    }
}
