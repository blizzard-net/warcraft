using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a guild.
    /// </summary>
    public record GuildReference
    {
        /// <summary>
        /// Gets the key for the guild.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the guild.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the guild.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets a reference to the guild's realm.
        /// </summary>
        [JsonPropertyName("realm")]
        public RealmReference Realm { get; }

        /// <summary>
        /// Gets the faction of the guild (Alliance or Horde).
        /// </summary>
        [JsonPropertyName("faction")]
        public EnumType Faction { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuildReference"/> class.
        /// </summary>
        /// <param name="key">The key for the guild.</param>
        /// <param name="name">The name of the guild.</param>
        /// <param name="id">The ID of the guild.</param>
        /// <param name="realm">A reference to the guild's realm.</param>
        /// <param name="faction">The faction of the guild (Alliance or Horde).</param>
        [JsonConstructor]
        public GuildReference(Self key, string name, int id, RealmReference realm, EnumType faction)
        {
            Key = key;
            Name = name;
            Id = id;
            Realm = realm;
            Faction = faction;
        }
    }
}
