using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of achievements.
    /// </summary>
    public class AchievementsIndex
    {
        /// <summary>
        /// Gets links for the index of achievements.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; private set; }

        /// <summary>
        /// Gets references to achievements.
        /// </summary>
        [JsonPropertyName("achievements")]
        public AchievementReference[] Achievements { get; private set; }
    }
}
