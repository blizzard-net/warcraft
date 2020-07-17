using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a guild.
    /// </summary>
    public class GuildReference
    {
        /// <summary>
        /// Gets the key for the guild.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the guild.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the guild.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets a reference to the guild's realm.
        /// </summary>
        [JsonPropertyName("realm")]
        public RealmReference Realm { get; set; }

        /// <summary>
        /// Gets the faction of the guild (Alliance or Horde).
        /// </summary>
        [JsonPropertyName("faction")]
        public EnumType Faction { get; set; }
    }
}
