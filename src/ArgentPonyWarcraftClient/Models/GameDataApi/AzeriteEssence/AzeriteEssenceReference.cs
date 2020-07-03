using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to an azerite essence.
    /// </summary>
    public class AzeriteEssenceReference
    {
        /// <summary>
        /// Gets the key for the azerite essence.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the azerite essence.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the azerite essence.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
