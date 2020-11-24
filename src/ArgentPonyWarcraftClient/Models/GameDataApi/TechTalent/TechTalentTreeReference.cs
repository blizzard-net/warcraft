using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a tech talent tree.
    /// </summary>
    public class TechTalentTreeReference
    {
        /// <summary>
        /// Gets the key for this tech talent tree.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the Id for this tech talent tree.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets the name for this tech talent tree.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
