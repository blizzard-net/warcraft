using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A creature type.
    /// </summary>
    public class CreatureType
    {
        /// <summary>
        /// Gets links for the creature type.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the creature type.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the creature type.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
