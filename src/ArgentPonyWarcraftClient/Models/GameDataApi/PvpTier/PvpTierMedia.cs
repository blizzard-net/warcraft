using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonProperty("assets")]
        public Asset[] Assets { get; set; }

        /// <summary>
        /// Gets the ID of the PvP tier.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
