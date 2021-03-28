using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A spell.
    /// </summary>
    public record Spell
    {
        /// <summary>
        /// Gets links for the spell.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the spell.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of the spell.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the description of the spell.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; }

        /// <summary>
        /// Gets the media associated with this spell.
        /// </summary>
        [JsonPropertyName("media")]
        public Media Media { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Spell"/> class.
        /// </summary>
        /// <param name="links">Links for the spell.</param>
        /// <param name="id">The ID of the spell.</param>
        /// <param name="name">The name of the spell.</param>
        /// <param name="description">The description of the spell.</param>
        /// <param name="media">The media associated with this spell.</param>
        [JsonConstructor]
        public Spell(Links links, int id, string name, string description, Media media)
        {
            Links = links;
            Id = id;
            Name = name;
            Description = description;
            Media = media;
        }
    }
}
