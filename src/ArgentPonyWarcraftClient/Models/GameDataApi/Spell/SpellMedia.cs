using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Spell media.
    /// </summary>
    public class SpellMedia
    {
        /// <summary>
        /// Gets links for the spell media.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonPropertyName("assets")]
        public Asset[] Assets { get; set; }

        /// <summary>
        /// Gets the ID of the spell.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
