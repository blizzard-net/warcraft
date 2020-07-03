using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; private set; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonProperty("assets")]
        public Asset[] Assets { get; private set; }

        /// <summary>
        /// Gets the ID of the azerite essence.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
