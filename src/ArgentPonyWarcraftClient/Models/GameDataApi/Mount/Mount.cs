using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A mount.
    /// </summary>
    public record Mount
    {
        /// <summary>
        /// Gets links for the mount.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the mount.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of the mount.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the creature displays media for the mount.
        /// </summary>
        [JsonPropertyName("creature_displays")]
        public Media[] CreatureDisplays { get; }

        /// <summary>
        /// Gets the description of the mount.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; }

        /// <summary>
        /// Gets the source for where the mount is acquired.
        /// </summary>
        [JsonPropertyName("source")]
        public EnumType Source { get; }

        /// <summary>
        /// Gets the faction for the mount.
        /// </summary>
        [JsonPropertyName("faction")]
        public EnumType Faction { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mount"/> class.
        /// </summary>
        /// <param name="links">Links for the mount.</param>
        /// <param name="id">The ID of the mount.</param>
        /// <param name="name">The name of the mount.</param>
        /// <param name="creatureDisplays">The creature displays media for the mount.</param>
        /// <param name="description">The description of the mount.</param>
        /// <param name="source">The source for where the mount is acquired.</param>
        /// <param name="faction">The faction for the mount.</param>
        [JsonConstructor]
        public Mount(Links links, int id, string name, Media[] creatureDisplays, string description, EnumType source, EnumType faction)
        {
            Links = links;
            Id = id;
            Name = name;
            CreatureDisplays = creatureDisplays;
            Description = description;
            Source = source;
            Faction = faction;
        }
    }
}
