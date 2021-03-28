using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A profession.
    /// </summary>
    public record Profession
    {
        /// <summary>
        /// Gets links for the profession.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the profession.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of the profession.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets a description of the profession.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; }

        /// <summary>
        /// Gets the type of the profession.
        /// </summary>
        [JsonPropertyName("type")]
        public EnumType Type { get; }

        /// <summary>
        /// Gets media associated with the profession.
        /// </summary>
        [JsonPropertyName("media")]
        public Media Media { get; }

        /// <summary>
        /// Gets references to the skill tiers for the profession.
        /// </summary>
        [JsonPropertyName("skill_tiers")]
        public SkillTierReference[] SkillTiers { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Profession"/> class.
        /// </summary>
        /// <param name="links">Links for the profession.</param>
        /// <param name="id">The ID of the profession.</param>
        /// <param name="name">The name of the profession.</param>
        /// <param name="description">A description of the profession.</param>
        /// <param name="type">The type of the profession.</param>
        /// <param name="media">Media associated with the profession.</param>
        /// <param name="skillTiers">References to the skill tiers for the profession.</param>
        [JsonConstructor]
        public Profession(Links links, int id, string name, string description, EnumType type, Media media, SkillTierReference[] skillTiers)
        {
            Links = links;
            Id = id;
            Name = name;
            Description = description;
            Type = type;
            Media = media;
            SkillTiers = skillTiers;
        }
    }
}
