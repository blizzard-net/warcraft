using System;
using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A recent achievement by a character or guild.
    /// </summary>
    public class RecentEvent
    {
        /// <summary>
        /// Gets a reference to the achievement.
        /// </summary>
        [JsonPropertyName("achievement")]
        public AchievementReference Achievement { get; set; }

        /// <summary>
        /// Gets the timestamp when the achievement was completed.
        /// </summary>
        [JsonPropertyName("timestamp")]
        public DateTimeOffset Timestamp { get; set; }
    }
}
