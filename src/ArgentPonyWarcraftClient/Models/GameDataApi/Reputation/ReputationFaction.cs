using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reputation faction.
    /// </summary>
    public record ReputationFaction
    {
        /// <summary>
        /// Gets links for the reputation faction.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the reputation faction.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of the reputation faction.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the description of the reputation faction.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; }

        /// <summary>
        /// Gets the reputation tiers for the reputation faction.
        /// </summary>
        [JsonPropertyName("reputation_tiers")]
        public ReputationTierReferenceWithoutName ReputationTiers { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReputationFaction"/> class.
        /// </summary>
        /// <param name="links">Links for the reputation faction.</param>
        /// <param name="id">The ID of the reputation faction.</param>
        /// <param name="name">The name of the reputation faction.</param>
        /// <param name="description">The description of the reputation faction.</param>
        /// <param name="reputationTiers">The reputation tiers for the reputation faction.</param>
        [JsonConstructor]
        public ReputationFaction(Links links, int id, string name, string description, ReputationTierReferenceWithoutName reputationTiers)
        {
            Links = links;
            Id = id;
            Name = name;
            Description = description;
            ReputationTiers = reputationTiers;
        }
    }
}
