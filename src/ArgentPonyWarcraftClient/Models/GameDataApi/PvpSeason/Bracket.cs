using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A PvP bracket.
    /// </summary>
    public class Bracket
    {
        /// <summary>
        /// Gets the ID of the PvP bracket.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the type of the PvP bracket.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
