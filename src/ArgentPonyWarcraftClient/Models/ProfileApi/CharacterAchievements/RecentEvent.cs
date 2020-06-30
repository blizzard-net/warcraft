using System;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A recent achievement by a character.
    /// </summary>
    public class RecentEvent
    {
        /// <summary>
        /// Gets a reference to the achievement.
        /// </summary>
        [JsonProperty("achievement")]
        public AchievementReference Achievement { get; set; }

        /// <summary>
        /// Gets the timestamp when the achievement was completed.
        /// </summary>
        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }
    }
}
