using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Creature display media.
    /// </summary>
    public class CreatureDisplayMedia
    {
        /// <summary>
        /// Gets links for the creature display media.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; private set; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonPropertyName("assets")]
        public Asset[] Assets { get; private set; }

        /// <summary>
        /// Gets the ID of the creature display.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
