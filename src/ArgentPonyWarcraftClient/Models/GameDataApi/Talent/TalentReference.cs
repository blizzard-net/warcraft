using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a talent.
    /// </summary>
    public class TalentReference
    {
        /// <summary>
        /// Gets the key for the talent.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the talent.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the talent.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
