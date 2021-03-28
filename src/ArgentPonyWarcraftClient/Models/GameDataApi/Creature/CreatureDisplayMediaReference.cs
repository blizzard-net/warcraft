using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to creature display media.
    /// </summary>
    public record CreatureDisplayMediaReference
    {
        /// <summary>
        /// Gets the key for the creature display media.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the ID of the creature display media.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatureDisplayMediaReference"/> class.
        /// </summary>
        /// <param name="key">The key for the creature display media.</param>
        /// <param name="id">The ID of the creature display media.</param>
        [JsonConstructor]
        public CreatureDisplayMediaReference(Self key, int id)
        {
            Key = key;
            Id = id;
        }
    }
}
