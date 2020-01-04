using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// An index of achievements.
    /// </summary>
    public class AchievementsIndex
    {
        /// <summary>
        /// Gets links for the index of achievements.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; private set; }

        /// <summary>
        /// Gets references to achievements.
        /// </summary>
        [JsonProperty("achievements")]
        public AchievementReference[] Achievements { get; private set; }
    }
}
