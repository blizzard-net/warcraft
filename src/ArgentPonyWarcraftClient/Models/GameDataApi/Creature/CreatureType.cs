using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A creature type.
    /// </summary>
    public record CreatureType
    {
        /// <summary>
        /// Gets links for the creature type.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the creature type.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of the creature type.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatureType"/> class.
        /// </summary>
        /// <param name="links">Links for the creature type.</param>
        /// <param name="id">The ID of the creature type.</param>
        /// <param name="name">The name of the creature type.</param>
        [JsonConstructor]
        public CreatureType(Links links, int id, string name)
        {
            Links = links;
            Id = id;
            Name = name;
        }
    }
}
