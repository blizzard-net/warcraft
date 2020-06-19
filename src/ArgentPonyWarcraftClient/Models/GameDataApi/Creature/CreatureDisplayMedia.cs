using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; private set; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonProperty("assets")]
        public Asset[] Assets { get; private set; }

        /// <summary>
        /// Gets the ID of the creature display.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
