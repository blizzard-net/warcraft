using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A summary of the achievements a character has completed.
    /// </summary>
    public record CharacterAchievementsSummary
    {
        /// <summary>
        /// Gets links for the character achievements summary.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the total number of achievements for this character.
        /// </summary>
        [JsonPropertyName("total_quantity")]
        public int TotalQuantity { get; }

        /// <summary>
        /// Gets the total number of achievement points for this character.
        /// </summary>
        [JsonPropertyName("total_points")]
        public int TotalPoints { get; }

        /// <summary>
        /// Gets the achievements for this character.
        /// </summary>
        [JsonPropertyName("achievements")]
        public AchievementProgress[] Achievements { get; }

        /// <summary>
        /// Gets the character's progress in various achievement categories.
        /// </summary>
        [JsonPropertyName("category_progress")]
        public CategoryProgress[] CategoryProgress { get; }

        /// <summary>
        /// Gets recent achievements by the character.
        /// </summary>
        [JsonPropertyName("recent_events")]
        public RecentEvent[] RecentEvents { get; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonPropertyName("character")]
        public CharacterReference Character { get; }

        /// <summary>
        /// Gets a link to the character's achievement statistics.
        /// </summary>
        [JsonPropertyName("statistics")]
        public Self Statistics { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterAchievementsSummary"/> class.
        /// </summary>
        /// <param name="links">Links for the character achievements summary.</param>
        /// <param name="totalQuantity">The total number of achievements for this character.</param>
        /// <param name="totalPoints">The total number of achievement points for this character.</param>
        /// <param name="achievements">The achievements for this character.</param>
        /// <param name="categoryProgress">The character's progress in various achievement categories.</param>
        /// <param name="recentEvents">Recent achievements by the character.</param>
        /// <param name="character">A reference to the character.</param>
        /// <param name="statistics">A link to the character's achievement statistics.</param>
        [JsonConstructor]
        public CharacterAchievementsSummary(Links links, int totalQuantity, int totalPoints, AchievementProgress[] achievements, CategoryProgress[] categoryProgress, RecentEvent[] recentEvents, CharacterReference character, Self statistics)
        {
            Links = links;
            TotalQuantity = totalQuantity;
            TotalPoints = totalPoints;
            Achievements = achievements;
            CategoryProgress = categoryProgress;
            RecentEvents = recentEvents;
            Character = character;
            Statistics = statistics;
        }
    }
}
