using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to the Mythic Keystone season details for a character.
    /// </summary>
    public record CharacterMythicKeystoneSeasonDetailsReference
    {
        /// <summary>
        /// Gets the key for the Mythic Keystone season details for a character.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the ID of the Mythic Keystone season details for a character.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterMythicKeystoneSeasonDetailsReference"/> class.
        /// </summary>
        /// <param name="key">The key for the Mythic Keystone season details for a character.</param>
        /// <param name="id">The ID of the Mythic Keystone season details for a character.</param>
        [JsonConstructor]
        public CharacterMythicKeystoneSeasonDetailsReference(Self key, int id)
        {
            Key = key;
            Id = id;
        }
    }
}
