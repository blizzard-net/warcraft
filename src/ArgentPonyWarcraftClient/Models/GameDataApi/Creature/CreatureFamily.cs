using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A creature family.
    /// </summary>
    public record CreatureFamily
    {
        /// <summary>
        /// Gets links for the creature family.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the creature family.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of the creature family.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the specialization of the creature family.
        /// </summary>
        [JsonPropertyName("specialization")]
        public PlayableSpecializationReference Specialization { get; }

        /// <summary>
        /// Gets media for the creature family.
        /// </summary>
        [JsonPropertyName("media")]
        public Media Media { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatureFamily"/> class.
        /// </summary>
        /// <param name="links">Links for the creature family.</param>
        /// <param name="id">The ID of the creature family.</param>
        /// <param name="name">The name of the creature family.</param>
        /// <param name="specialization">The specialization of the creature family.</param>
        /// <param name="media">Media for the creature family.</param>
        [JsonConstructor]
        public CreatureFamily(Links links, int id, string name, PlayableSpecializationReference specialization, Media media)
        {
            Links = links;
            Id = id;
            Name = name;
            Specialization = specialization;
            Media = media;
        }
    }
}
