using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Media for an azerite essence.
    /// </summary>
    public class AzeriteEssenceMedia
    {
        /// <summary>
        /// Gets links for the azerite essence media.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; private set; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonPropertyName("assets")]
        public Asset[] Assets { get; private set; }

        /// <summary>
        /// Gets the ID of the azerite essence.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
