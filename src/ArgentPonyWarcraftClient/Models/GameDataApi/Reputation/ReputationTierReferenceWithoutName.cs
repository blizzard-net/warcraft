using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a reputation tier.
    /// </summary>
    public class ReputationTierReferenceWithoutName
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
        public int Id { get; set; }
    }
}
