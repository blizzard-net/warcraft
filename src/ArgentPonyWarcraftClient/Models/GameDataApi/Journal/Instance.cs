using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// A dungeon or raid.
    /// </summary>
    public class Instance
    {
        /// <summary>
        /// Gets links for the instance.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the instance.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the instance.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the map of the instance.
        /// </summary>
        [JsonProperty("map")]
        public Map Map { get; set; }

        /// <summary>
        /// Gets the area where the instance is found.
        /// </summary>
        [JsonProperty("area")]
        public Area Area { get; set; }

        /// <summary>
        /// Gets the description of the instance.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets the encounters found within the instance.
        /// </summary>
        [JsonProperty("encounters")]
        public EncounterReference[] Encounters { get; set; }

        /// <summary>
        /// Gets a reference to the game expansion where this instance was introduced.
        /// </summary>
        [JsonProperty("expansion")]
        public ExpansionReference Expansion { get; set; }

        /// <summary>
        /// Gets the location of the instance.
        /// </summary>
        [JsonProperty("location")]
        public Location Location { get; set; }

        /// <summary>
        /// Gets the available difficulty modes for the instance.
        /// </summary>
        [JsonProperty("modes")]
        public InstanceMode[] Modes { get; set; }

        /// <summary>
        /// Gets the media associated with the instance.
        /// </summary>
        [JsonProperty("media")]
        public Media Media { get; set; }

        /// <summary>
        /// Gets the minimum character level for the instance.
        /// </summary>
        [JsonProperty("minimum_level")]
        public long MinimumLevel { get; set; }

        /// <summary>
        /// Gets the category of the instance (i.e., "DUNGEON" or "RAID").
        /// </summary>
        [JsonProperty("category")]
        public InstanceCategory Category { get; set; }
    }
}
