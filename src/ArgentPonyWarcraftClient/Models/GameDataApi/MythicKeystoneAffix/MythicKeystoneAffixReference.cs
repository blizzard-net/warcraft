using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a mythic keystone affix.
    /// </summary>
    public record MythicKeystoneAffixReference
    {
        /// <summary>
        /// Gets the key for the keystone affix.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the keystone affix.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the keystone affix.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MythicKeystoneAffixReference"/> class.
        /// </summary>
        /// <param name="key">The key for the keystone affix.</param>
        /// <param name="name">The name of the keystone affix.</param>
        /// <param name="id">The ID of the keystone affix.</param>
        [JsonConstructor]
        public MythicKeystoneAffixReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
