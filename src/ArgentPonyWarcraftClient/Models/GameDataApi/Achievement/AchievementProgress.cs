using System;
using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An achievement for a character or guild.
    /// </summary>
    public record AchievementProgress
    {
        /// <summary>
        /// Gets the ID of the achievement.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets a reference to the achievement.
        /// </summary>
        [JsonPropertyName("achievement")]
        public AchievementReference Achievement { get; }

        /// <summary>
        /// Gets the criteria for the achievement.
        /// </summary>
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; }

        /// <summary>
        /// Gets the timestamp when the character or guild completed the achievement, or <c>null</c> if it has not been completed.
        /// </summary>
        [JsonPropertyName("completed_timestamp")]
        public DateTimeOffset? CompletedTimestamp { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AchievementProgress"/> class.
        /// </summary>
        /// <param name="id">The ID of the achievement.</param>
        /// <param name="achievement">A reference to the achievement.</param>
        /// <param name="criteria">The criteria for the achievement.</param>
        /// <param name="completedTimestamp">The timestamp when the character or guild completed the achievement, or <c>null</c> if it has not been completed.</param>
        [JsonConstructor]
        public AchievementProgress(int id, AchievementReference achievement, Criteria criteria, DateTimeOffset? completedTimestamp)
        {
            Id = id;
            Achievement = achievement;
            Criteria = criteria;
            CompletedTimestamp = completedTimestamp;
        }
    }
}
