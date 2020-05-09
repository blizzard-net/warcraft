using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// A tier of content.
    /// </summary>
    public class Tier
    {
        /// <summary>
        /// Gets the key for the tier.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the tier.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the tier.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
