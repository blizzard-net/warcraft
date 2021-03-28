using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to azerite essence media.
    /// </summary>
    public class AzeritEssenceMediaReference
    {
        /// <summary>
        /// Gets the key for the azerite essence media.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the ID of the azerite essence.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
