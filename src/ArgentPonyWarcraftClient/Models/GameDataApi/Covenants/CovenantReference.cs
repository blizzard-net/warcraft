using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a covenant.
    /// </summary>
    public class CovenantReference
    {
        /// <summary>
        /// Gets the key for this covenant.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of this covenant.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of this covenant.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
