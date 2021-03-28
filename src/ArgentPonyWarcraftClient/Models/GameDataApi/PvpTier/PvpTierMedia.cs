using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// PvP tier media.
    /// </summary>
    public class PvpTierMedia
    {
        /// <summary>
        /// Gets links for the PvP tier media.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonPropertyName("assets")]
        public Asset[] Assets { get; set; }

        /// <summary>
        /// Gets the ID of the PvP tier.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
