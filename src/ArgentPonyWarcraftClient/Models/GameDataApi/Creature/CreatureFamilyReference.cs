using System.Text.Json.Serialization;

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
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the creature family.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the creature family.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
