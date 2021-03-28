using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a power type.
    /// </summary>
    public class PowerTypeReference
    {
        /// <summary>
        /// Gets the key for the power type.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the power type.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the power type.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
