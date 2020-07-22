using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a talent.
    /// </summary>
    public class TalentReference
    {
        /// <summary>
        /// Gets the key for the talent.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the talent.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the talent.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
