using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a PvP talent.
    /// </summary>
    public class PvpTalentReference
    {
        /// <summary>
        /// Gets the key for the PvP talent.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the PvP talent.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the PvP talent.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
