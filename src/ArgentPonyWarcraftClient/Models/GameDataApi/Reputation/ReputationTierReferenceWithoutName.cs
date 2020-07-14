using Newtonsoft.Json;

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
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the ID of the reputation tier.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
