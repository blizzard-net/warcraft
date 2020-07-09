using System;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An achievement for a character or guild.
    /// </summary>
    public class AchievementProgress
    {
        /// <summary>
        /// Gets the ID of the achievement.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets a reference to the achievement.
        /// </summary>
        [JsonProperty("achievement")]
        public AchievementReference Achievement { get; set; }

        /// <summary>
        /// Gets the criteria for the achievement.
        /// </summary>
        [JsonProperty("criteria", NullValueHandling = NullValueHandling.Ignore)]
        public Criteria Criteria { get; set; }

        /// <summary>
        /// Gets the timestamp when the character or guild completed the achievement, or <c>null</c> if it has not been completed.
        /// </summary>
        [JsonProperty("completed_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CompletedTimestamp { get; set; }
    }
}
