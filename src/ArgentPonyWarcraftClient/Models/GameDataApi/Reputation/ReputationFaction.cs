using System.Text.Json.Serialization;

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
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the reputation faction.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the reputation faction.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the description of the reputation faction.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets the reputation tiers for the reputation faction.
        /// </summary>
        [JsonPropertyName("reputation_tiers")]
        public ReputationTierReferenceWithoutName ReputationTiers { get; set; }
    }
}
