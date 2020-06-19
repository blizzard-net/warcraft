using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a creature family.
    /// </summary>
    public class CreatureFamilyReference
    {
        /// <summary>
        /// Gets the key for the creature family.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the creature family.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the creature family.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
