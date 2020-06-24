using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a profession.
    /// </summary>
    public class ProfessionReference
    {
        /// <summary>
        /// Gets the key for the profession.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the profession.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the profession.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
