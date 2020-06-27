using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A spell.
    /// </summary>
    public class Spell
    {
        /// <summary>
        /// Gets links for the spell.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the spell.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the spell.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the description of the spell.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets the media associated with this spell.
        /// </summary>
        [JsonProperty("media")]
        public Media Media { get; set; }
    }
}
