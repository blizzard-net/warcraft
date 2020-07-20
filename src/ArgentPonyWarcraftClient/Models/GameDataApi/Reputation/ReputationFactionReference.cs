using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a reputation faction.
    /// </summary>
    public class ReputationFactionReference
    {
        /// <summary>
        /// Gets the key for the reputation faction.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the reputation faction.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the reputation faction.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
