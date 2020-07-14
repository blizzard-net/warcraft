using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reputation faction.
    /// </summary>
    public class ReputationFaction
    {
        /// <summary>
        /// Gets links for the reputation faction.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the reputation faction.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the reputation faction.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the description of the reputation faction.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets the reputation tiers for the reputation faction.
        /// </summary>
        [JsonProperty("reputation_tiers")]
        public ReputationTierReferenceWithoutName ReputationTiers { get; set; }
    }
}
