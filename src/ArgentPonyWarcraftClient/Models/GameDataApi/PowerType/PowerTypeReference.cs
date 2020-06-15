using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a power type.
    /// </summary>
    public class PowerTypeReference
    {
        /// <summary>
        /// Gets the key for the power type.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the power type.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the power type.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
