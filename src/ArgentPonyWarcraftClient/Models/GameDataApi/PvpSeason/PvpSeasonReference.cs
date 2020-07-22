using System.Text.Json.Serialization;

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
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the ID of the PvP season.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
