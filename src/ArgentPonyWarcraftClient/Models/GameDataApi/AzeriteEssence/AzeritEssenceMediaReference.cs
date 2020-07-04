using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to azerite essence media.
    /// </summary>
    public class AzeritEssenceMediaReference
    {
        /// <summary>
        /// Gets the key for the azerite essence media.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the ID of the azerite essence.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
