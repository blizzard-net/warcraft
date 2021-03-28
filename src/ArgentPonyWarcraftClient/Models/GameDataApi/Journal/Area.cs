using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An area.
    /// </summary>
    public record Area
    {
        /// <summary>
        /// Gets the name of the area.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the area.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Area"/> class.
        /// </summary>
        /// <param name="name">The name of the area.</param>
        /// <param name="id">The ID of the area.</param>
        [JsonConstructor]
        public Area(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}
