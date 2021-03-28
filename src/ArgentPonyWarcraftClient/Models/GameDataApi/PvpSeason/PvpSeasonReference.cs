using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a PvP season.
    /// </summary>
    public record PvpSeasonReference
    {
        /// <summary>
        /// Gets the key for the PvP season.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the ID of the PvP season.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PvpSeasonReference"/> class.
        /// </summary>
        /// <param name="key">The key for the PvP season.</param>
        /// <param name="id">The ID of the PvP season.</param>
        [JsonConstructor]
        public PvpSeasonReference(Self key, int id)
        {
            Key = key;
            Id = id;
        }
    }
}
