using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a guild.
    /// </summary>
    public record GuildReferenceWithoutKeyAndFaction
    {
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
        /// Gets a reference to the realm to which the guild belongs.
        /// </summary>
        [JsonPropertyName("realm")]
        public RealmReferenceWithoutKey Realm { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuildReferenceWithoutKeyAndFaction"/> class.
        /// </summary>
        /// <param name="name">The name of the guild.</param>
        /// <param name="id">The ID of the guild.</param>
        /// <param name="realm">A reference to the realm to which the guild belongs.</param>
        [JsonConstructor]
        public GuildReferenceWithoutKeyAndFaction(string name, int id, RealmReferenceWithoutKey realm)
        {
            Name = name;
            Id = id;
            Realm = realm;
        }
    }
}
