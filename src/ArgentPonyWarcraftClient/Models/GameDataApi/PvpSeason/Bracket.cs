using System.Text.Json.Serialization;

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
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the type of the PvP bracket.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
