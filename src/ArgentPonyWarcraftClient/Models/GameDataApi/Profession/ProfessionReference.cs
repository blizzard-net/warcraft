using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a profession.
    /// </summary>
    public class ProfessionReference
    {
        /// <summary>
        /// Gets the key for the profession.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the profession.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the profession.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
