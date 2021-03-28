using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A region.
    /// </summary>
    public record RegionData
    {
        /// <summary>
        /// Gets links for the region.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the region.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of the region.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the tag for the region.
        /// </summary>
        [JsonPropertyName("tag")]
        public string Tag { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionData"/> class.
        /// </summary>
        /// <param name="links">Links for the region.</param>
        /// <param name="id">The ID of the region.</param>
        /// <param name="name">The name of the region.</param>
        /// <param name="tag">The tag for the region.</param>
        [JsonConstructor]
        public RegionData(Links links, int id, string name, string tag)
        {
            Links = links;
            Id = id;
            Name = name;
            Tag = tag;
        }
    }
}
