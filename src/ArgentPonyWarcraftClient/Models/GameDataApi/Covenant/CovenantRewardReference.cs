using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a covenant reward.
    /// </summary>
    public class CovenantRewardReference
    {
        /// <summary>
        /// Gets the key for the covenant reward.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name for the covenant reward.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the Id for the covenant reward.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
