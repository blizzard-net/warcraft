using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A guild's achievements.
    /// </summary>
    public class GuildAchievements
    {
        /// <summary>
        /// Gets links for the guild's achievements.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a reference to the guild.
        /// </summary>
        [JsonPropertyName("guild")]
        public GuildReference Guild { get; set; }

        /// <summary>
        /// Gets the total number of guild achievements.
        /// </summary>
        [JsonPropertyName("total_quantity")]
        public long TotalQuantity { get; set; }

        /// <summary>
        /// Gets the total number of guild achievement points.
        /// </summary>
        [JsonPropertyName("total_points")]
        public long TotalPoints { get; set; }

        /// <summary>
        /// Gets the guild achievements.
        /// </summary>
        [JsonPropertyName("achievements")]
        public AchievementProgress[] Achievements { get; set; }

        /// <summary>
        /// Gets the guild's progress in various achievement categories.
        /// </summary>
        [JsonPropertyName("category_progress")]
        public CategoryProgress[] CategoryProgress { get; set; }

        /// <summary>
        /// Gets recent achievements by the guild.
        /// </summary>
        [JsonPropertyName("recent_events")]
        public RecentEvent[] RecentEvents { get; set; }
    }
}
