using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A map.
    /// </summary>
    public record Map
    {
        /// <summary>
        /// Gets the name of the map.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the map.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Map"/> class.
        /// </summary>
        /// <param name="name">The name of the map.</param>
        /// <param name="id">The ID of the map.</param>
        [JsonConstructor]
        public Map(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}
