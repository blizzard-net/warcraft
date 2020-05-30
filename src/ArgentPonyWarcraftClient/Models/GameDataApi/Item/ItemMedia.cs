using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// Item media.
    /// </summary>
    public class ItemMedia
    {
        /// <summary>
        /// Gets links for the achievement media.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; private set; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonProperty("assets")]
        public Asset[] Assets { get; private set; }

        /// <summary>
        /// Gets the ID of the item.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
