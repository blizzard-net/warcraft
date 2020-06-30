using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a PvP season.
    /// </summary>
    public class PvpSeasonReference
    {
        /// <summary>
        /// Gets the key for the PvP season.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the ID of the PvP season.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
