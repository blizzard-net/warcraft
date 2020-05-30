using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to game expansion.
    /// </summary>
    public class ExpansionReference
    {
        /// <summary>
        /// Gets the key for the expansion.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the expansion.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the expansion.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
