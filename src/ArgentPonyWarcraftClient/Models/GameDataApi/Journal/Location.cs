using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A location.
    /// </summary>
    public record Location
    {
        /// <summary>
        /// Gets the name of the location.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the location.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Location"/> class.
        /// </summary>
        /// <param name="name">The name of the location.</param>
        /// <param name="id">The ID of the location.</param>
        [JsonConstructor]
        public Location(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}
