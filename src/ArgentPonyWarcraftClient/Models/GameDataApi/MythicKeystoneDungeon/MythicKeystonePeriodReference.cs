using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a Mythic Keystone period.
    /// </summary>
    public record MythicKeystonePeriodReference
    {
        /// <summary>
        /// Gets the key for the Mythic Keystone period.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the ID of the Mythic Keystone period.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MythicKeystonePeriodReference"/> class.
        /// </summary>
        /// <param name="key">The key for the Mythic Keystone period.</param>
        /// <param name="id">The ID of the Mythic Keystone period.</param>
        [JsonConstructor]
        public MythicKeystonePeriodReference(Self key, int id)
        {
            Key = key;
            Id = id;
        }
    }
}
