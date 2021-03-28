using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A media reference.
    /// </summary>
    public record Media
    {
        /// <summary>
        /// Gets the key for the media.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the ID of the media.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Media"/> class.
        /// </summary>
        /// <param name="key">The key for the media.</param>
        /// <param name="id">The ID of the media.</param>
        [JsonConstructor]
        public Media(Self key, int id)
        {
            Key = key;
            Id = id;
        }
    }
}
