using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// Achievement media.
    /// </summary>
    public class AchievementMedia
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
    }
}
