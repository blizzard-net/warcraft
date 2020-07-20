using System.Text.Json.Serialization;

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
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the creature type.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the creature type.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
