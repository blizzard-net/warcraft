using System;
using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A recent achievement by a character or guild.
    /// </summary>
    public record RecentEvent
    {
        /// <summary>
        /// Gets a reference to the achievement.
        /// </summary>
        [JsonPropertyName("achievement")]
        public AchievementReference Achievement { get; }

        /// <summary>
        /// Gets the timestamp when the achievement was completed.
        /// </summary>
        [JsonPropertyName("timestamp")]
        public DateTimeOffset Timestamp { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecentEvent"/> class.
        /// </summary>
        /// <param name="achievement">A reference to the achievement.</param>
        /// <param name="timestamp">The timestamp when the achievement was completed.</param>
        [JsonConstructor]
        public RecentEvent(AchievementReference achievement, DateTimeOffset timestamp)
        {
            Achievement = achievement;
            Timestamp = timestamp;
        }
    }
}
