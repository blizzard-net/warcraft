using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a reputation faction.
    /// </summary>
    public class ReputationFactionReference
    {
        /// <summary>
        /// Gets the key for the reputation faction.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the reputation faction.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the reputation faction.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
