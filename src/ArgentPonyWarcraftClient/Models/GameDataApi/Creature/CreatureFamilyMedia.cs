using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; private set; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonProperty("assets")]
        public Asset[] Assets { get; private set; }

        /// <summary>
        /// Gets the ID of the creature family.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
