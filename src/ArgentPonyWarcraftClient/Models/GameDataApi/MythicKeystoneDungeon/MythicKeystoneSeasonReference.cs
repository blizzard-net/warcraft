using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a Mythic Keystone season.
    /// </summary>
    public record MythicKeystoneSeasonReference
    {
        /// <summary>
        /// Gets the key for the Mythic Keystone season.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the ID of the Mythic Keystone season.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MythicKeystoneSeasonReference"/> class.
        /// </summary>
        /// <param name="key">The key for the Mythic Keystone season.</param>
        /// <param name="id">The ID of the Mythic Keystone season.</param>
        [JsonConstructor]
        public MythicKeystoneSeasonReference(Self key, int id)
        {
            Key = key;
            Id = id;
        }
    }
}
