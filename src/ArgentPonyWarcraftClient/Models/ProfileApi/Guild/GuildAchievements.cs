using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A guild's achievements.
    /// </summary>
    public record GuildAchievements
    {
        /// <summary>
        /// Gets links for the guild's achievements.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a reference to the guild.
        /// </summary>
        [JsonPropertyName("guild")]
        public GuildReference Guild { get; }

        /// <summary>
        /// Gets the total number of guild achievements.
        /// </summary>
        [JsonPropertyName("total_quantity")]
        public int TotalQuantity { get; }

        /// <summary>
        /// Gets the total number of guild achievement points.
        /// </summary>
        [JsonPropertyName("total_points")]
        public int TotalPoints { get; }

        /// <summary>
        /// Gets the guild achievements.
        /// </summary>
        [JsonPropertyName("achievements")]
        public AchievementProgress[] Achievements { get; }

        /// <summary>
        /// Gets the guild's progress in various achievement categories.
        /// </summary>
        [JsonPropertyName("category_progress")]
        public CategoryProgress[] CategoryProgress { get; }

        /// <summary>
        /// Gets recent achievements by the guild.
        /// </summary>
        [JsonPropertyName("recent_events")]
        public RecentEvent[] RecentEvents { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuildAchievements"/> class.
        /// </summary>
        /// <param name="links">Links for the guild's achievements.</param>
        /// <param name="guild">A reference to the guild.</param>
        /// <param name="totalQuantity">The total number of guild achievements.</param>
        /// <param name="totalPoints">The total number of guild achievement points.</param>
        /// <param name="achievements">The guild achievements.</param>
        /// <param name="categoryProgress">The guild's progress in various achievement categories.</param>
        /// <param name="recentEvents">Recent achievements by the guild.</param>
        [JsonConstructor]
        public GuildAchievements(Links links, GuildReference guild, int totalQuantity, int totalPoints, AchievementProgress[] achievements, CategoryProgress[] categoryProgress, RecentEvent[] recentEvents)
        {
            Links = links;
            Guild = guild;
            TotalQuantity = totalQuantity;
            TotalPoints = totalPoints;
            Achievements = achievements;
            CategoryProgress = categoryProgress;
            RecentEvents = recentEvents;
        }
    }
}
