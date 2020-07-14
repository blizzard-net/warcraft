using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character's reputation with a faction.
    /// </summary>
    public class Reputation
    {
        /// <summary>
        /// Gets a reference to the reputation faction.
        /// </summary>
        [JsonProperty("faction")]
        public ReputationFactionReference Faction { get; set; }

        /// <summary>
        /// Gets the character's standing with the reputation faction.
        /// </summary>
        [JsonProperty("standing")]
        public Standing Standing { get; set; }

        /// <summary>
        /// Gets the character's paragon status with the reputation faction.
        /// </summary>
        [JsonProperty("paragon", NullValueHandling = NullValueHandling.Ignore)]
        public Paragon Paragon { get; set; }
    }
}
