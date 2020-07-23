using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Criteria for an achievement.
    /// </summary>
    public class AchievementCriteria
    {
        /// <summary>
        /// Gets the ID of the criteria.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets the description of the criteria.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets the amount of the criteria.
        /// </summary>
        [JsonPropertyName("amount")]
        public int Amount { get; set; }
    }
}
