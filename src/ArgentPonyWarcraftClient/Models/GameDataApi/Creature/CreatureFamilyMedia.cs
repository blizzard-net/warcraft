using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Creature family media.
    /// </summary>
    public class CreatureFamilyMedia
    {
        /// <summary>
        /// Gets links for the creature family media.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; private set; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonPropertyName("assets")]
        public Asset[] Assets { get; private set; }

        /// <summary>
        /// Gets the ID of the creature family.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
