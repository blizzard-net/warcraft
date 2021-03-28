using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character's reputation with a faction.
    /// </summary>
    public record Reputation
    {
        /// <summary>
        /// Gets a reference to the reputation faction.
        /// </summary>
        [JsonPropertyName("faction")]
        public ReputationFactionReference Faction { get; }

        /// <summary>
        /// Gets the character's standing with the reputation faction.
        /// </summary>
        [JsonPropertyName("standing")]
        public Standing Standing { get; }

        /// <summary>
        /// Gets the character's paragon status with the reputation faction.
        /// </summary>
        [JsonPropertyName("paragon")]
        public Paragon Paragon { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Reputation"/> class.
        /// </summary>
        /// <param name="faction">A reference to the reputation faction.</param>
        /// <param name="standing">The character's standing with the reputation faction.</param>
        /// <param name="paragon">The character's paragon status with the reputation faction.</param>
        [JsonConstructor]
        public Reputation(ReputationFactionReference faction, Standing standing, Paragon paragon)
        {
            Faction = faction;
            Standing = standing;
            Paragon = paragon;
        }
    }
}
