using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a creature type.
    /// </summary>
    public class CreatureTypeReference
    {
        /// <summary>
        /// Gets the key for the creature type.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the creature type.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the creature type.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
