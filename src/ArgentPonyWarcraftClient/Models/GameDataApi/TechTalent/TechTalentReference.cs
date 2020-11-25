using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a tech talent.
    /// </summary>
    public class TechTalentReference
    {
        /// <summary>
        /// Gets the key for the tech talent.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the tech talent.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the tech talent.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
