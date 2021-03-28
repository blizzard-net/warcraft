using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A power type.
    /// </summary>
    public record PowerType
    {
        /// <summary>
        /// Gets links for the power type.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the power type.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of the power type.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PowerType"/> class.
        /// </summary>
        /// <param name="links">Links for the power type.</param>
        /// <param name="id">The ID of the power type.</param>
        /// <param name="name">The name of the power type.</param>
        [JsonConstructor]
        public PowerType(Links links, int id, string name)
        {
            Links = links;
            Id = id;
            Name = name;
        }
    }
}
