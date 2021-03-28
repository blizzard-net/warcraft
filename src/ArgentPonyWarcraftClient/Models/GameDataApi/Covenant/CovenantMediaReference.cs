using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to media for a particular covenant.
    /// </summary>
    public class CovenantMediaReference
    {
        /// <summary>
        /// Gets the key for the covenant media reference.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the Id for the covenant media reference.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
