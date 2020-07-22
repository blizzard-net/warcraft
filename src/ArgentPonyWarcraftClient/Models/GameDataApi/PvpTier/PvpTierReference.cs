using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a PvP tier.
    /// </summary>
    public class PvpTierReference
    {
        /// <summary>
        /// Gets the key for the PvP tier.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the PvP tier.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the PvP tier.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
