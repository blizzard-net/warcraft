using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// A reference to a creature.
    /// </summary>
    public class CreatureReference
    {
        /// <summary>
        /// Gets the key for the creature.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the creature.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the creature.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
