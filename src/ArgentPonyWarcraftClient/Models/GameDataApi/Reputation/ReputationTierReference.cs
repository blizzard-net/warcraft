using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a reputation tier.
    /// </summary>
    public class ReputationTierReference
    {
        /// <summary>
        /// Gets the key for the reputation tier.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the ID of the reputation tier.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the reputation tier.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
