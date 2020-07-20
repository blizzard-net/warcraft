using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A dungeon or raid.
    /// </summary>
    public class Instance
    {
        /// <summary>
        /// Gets links for the instance.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the instance.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the instance.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the map of the instance.
        /// </summary>
        [JsonPropertyName("map")]
        public Map Map { get; set; }

        /// <summary>
        /// Gets the area where the instance is found.
        /// </summary>
        [JsonPropertyName("area")]
        public Area Area { get; set; }

        /// <summary>
        /// Gets the description of the instance.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets the encounters found within the instance.
        /// </summary>
        [JsonPropertyName("encounters")]
        public EncounterReference[] Encounters { get; set; }

        /// <summary>
        /// Gets a reference to the game expansion where this instance was introduced.
        /// </summary>
        [JsonPropertyName("expansion")]
        public ExpansionReference Expansion { get; set; }

        /// <summary>
        /// Gets the location of the instance.
        /// </summary>
        [JsonPropertyName("location")]
        public Location Location { get; set; }

        /// <summary>
        /// Gets the available difficulty modes for the instance.
        /// </summary>
        [JsonPropertyName("modes")]
        public InstanceMode[] Modes { get; set; }

        /// <summary>
        /// Gets the media associated with the instance.
        /// </summary>
        [JsonPropertyName("media")]
        public Media Media { get; set; }

        /// <summary>
        /// Gets the minimum character level for the instance.
        /// </summary>
        [JsonPropertyName("minimum_level")]
        public long MinimumLevel { get; set; }

        /// <summary>
        /// Gets the category of the instance (i.e., "DUNGEON" or "RAID").
        /// </summary>
        [JsonPropertyName("category")]
        public InstanceCategory Category { get; set; }
    }
}
