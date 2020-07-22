using System.Text.Json.Serialization;

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
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the PvP talent.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the PvP talent.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
