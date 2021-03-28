using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A dungeon or raid.
    /// </summary>
    public record Instance
    {
        /// <summary>
        /// Gets links for the instance.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the instance.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of the instance.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the map of the instance.
        /// </summary>
        [JsonPropertyName("map")]
        public Map Map { get; }

        /// <summary>
        /// Gets the area where the instance is found.
        /// </summary>
        [JsonPropertyName("area")]
        public Area Area { get; }

        /// <summary>
        /// Gets the description of the instance.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; }

        /// <summary>
        /// Gets the encounters found within the instance.
        /// </summary>
        [JsonPropertyName("encounters")]
        public EncounterReference[] Encounters { get; }

        /// <summary>
        /// Gets a reference to the game expansion where this instance was introduced.
        /// </summary>
        [JsonPropertyName("expansion")]
        public ExpansionReference Expansion { get; }

        /// <summary>
        /// Gets the location of the instance.
        /// </summary>
        [JsonPropertyName("location")]
        public Location Location { get; }

        /// <summary>
        /// Gets the available difficulty modes for the instance.
        /// </summary>
        [JsonPropertyName("modes")]
        public InstanceMode[] Modes { get; }

        /// <summary>
        /// Gets the media associated with the instance.
        /// </summary>
        [JsonPropertyName("media")]
        public Media Media { get; }

        /// <summary>
        /// Gets the minimum character level for the instance.
        /// </summary>
        [JsonPropertyName("minimum_level")]
        public int MinimumLevel { get; }

        /// <summary>
        /// Gets the category of the instance (i.e., "DUNGEON" or "RAID").
        /// </summary>
        [JsonPropertyName("category")]
        public InstanceCategory Category { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Instance"/> class.
        /// </summary>
        /// <param name="links">Links for the instance.</param>
        /// <param name="id">The ID of the instance.</param>
        /// <param name="name">The name of the instance.</param>
        /// <param name="map">The map of the instance.</param>
        /// <param name="area">The area where the instance is found.</param>
        /// <param name="description">The description of the instance.</param>
        /// <param name="encounters">The encounters found within the instance.</param>
        /// <param name="expansion">A reference to the game expansion where this instance was introduced.</param>
        /// <param name="location">The location of the instance.</param>
        /// <param name="modes">The available difficulty modes for the instance.</param>
        /// <param name="media">The media associated with the instance.</param>
        /// <param name="minimumLevel">The minimum character level for the instance.</param>
        /// <param name="category">The category of the instance (i.e., "DUNGEON" or "RAID").</param>
        [JsonConstructor]
        public Instance(Links links, int id, string name, Map map, Area area, string description, EncounterReference[] encounters, ExpansionReference expansion, Location location, InstanceMode[] modes, Media media, int minimumLevel, InstanceCategory category)
        {
            Links = links;
            Id = id;
            Name = name;
            Map = map;
            Area = area;
            Description = description;
            Encounters = encounters;
            Expansion = expansion;
            Location = location;
            Modes = modes;
            Media = media;
            MinimumLevel = minimumLevel;
            Category = category;
        }
    }
}
