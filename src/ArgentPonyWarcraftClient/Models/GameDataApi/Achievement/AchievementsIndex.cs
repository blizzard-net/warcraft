using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of achievements.
    /// </summary>
    public record AchievementsIndex
    {
        /// <summary>
        /// Gets links for the index of achievements.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to achievements.
        /// </summary>
        [JsonPropertyName("achievements")]
        public AchievementReference[] Achievements { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AchievementsIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of achievements.</param>
        /// <param name="achievements">References to achievements.</param>
        [JsonConstructor]
        public AchievementsIndex(Links links, AchievementReference[] achievements)
        {
            Links = links;
            Achievements = achievements;
        }
    }
}
