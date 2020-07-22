using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to an azerite essence.
    /// </summary>
    public class AzeriteEssenceReference
    {
        /// <summary>
        /// Gets the key for the azerite essence.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the azerite essence.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the azerite essence.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
