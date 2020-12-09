using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A tech talent tree.
    /// </summary>
    public class TechTalentTree
    {
        /// <summary>
        /// Gets links for the tech talent tree.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the Id for the tech talent tree.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// The maximum tiers of the talent tree.
        /// </summary>
        [JsonPropertyName("max_tiers")]
        public int MaxTiers { get; set; }

        /// <summary>
        /// The collection of talents in the tech talent tree.
        /// </summary>
        [JsonPropertyName("talents")]
        public TechTalentReference[] Talents { get; set; }
    }
}
