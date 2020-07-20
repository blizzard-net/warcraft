using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Profession media.
    /// </summary>
    public class ProfessionMedia
    {
        /// <summary>
        /// Gets links for the profession media.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; private set; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonPropertyName("assets")]
        public Asset[] Assets { get; private set; }

        /// <summary>
        /// Gets the ID of the profession.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
