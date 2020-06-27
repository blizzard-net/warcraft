using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonProperty("assets")]
        public Asset[] Assets { get; set; }

        /// <summary>
        /// Gets the ID of the spell.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
