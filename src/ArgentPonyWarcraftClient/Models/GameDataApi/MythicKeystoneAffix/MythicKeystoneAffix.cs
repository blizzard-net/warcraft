using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A mythic keystone affix.
    /// </summary>
    public record MythicKeystoneAffix
    {
        /// <summary>
        /// Gets links for the mythic keystone affix.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the mythic keystone affix.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of the mythic keystone affix.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the description of the mythic keystone affix.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; }

        /// <summary>
        /// Gets the media for this mythic keystone affix.
        /// </summary>
        [JsonPropertyName("media")]
        public Media Media { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MythicKeystoneAffix"/> class.
        /// </summary>
        /// <param name="links">Links for the mythic keystone affix.</param>
        /// <param name="id">The ID of the mythic keystone affix.</param>
        /// <param name="name">The name of the mythic keystone affix.</param>
        /// <param name="description">The description of the mythic keystone affix.</param>
        /// <param name="media">The media for this mythic keystone affix.</param>
        [JsonConstructor]
        public MythicKeystoneAffix(Links links, int id, string name, string description, Media media)
        {
            Links = links;
            Id = id;
            Name = name;
            Description = description;
            Media = media;
        }
    }
}
