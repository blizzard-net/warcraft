using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a creature.
    /// </summary>
    public class CreatureReference
    {
        /// <summary>
        /// Gets the key for the creature.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the creature.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the creature.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
