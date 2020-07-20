using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Achievement media.
    /// </summary>
    public class AchievementMedia
    {
        /// <summary>
        /// Gets links for the achievement media.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; private set; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonPropertyName("assets")]
        public Asset[] Assets { get; private set; }
    }
}
