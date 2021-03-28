using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Criteria for an achievement.
    /// </summary>
    public record AchievementCriteria
    {
        /// <summary>
        /// Gets the ID of the criteria.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the description of the criteria.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; }

        /// <summary>
        /// Gets the amount of the criteria.
        /// </summary>
        [JsonPropertyName("amount")]
        public int Amount { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AchievementCriteria"/> class.
        /// </summary>
        /// <param name="id">The ID of the criteria.</param>
        /// <param name="description">The description of the criteria.</param>
        /// <param name="amount">The amount of the criteria.</param>
        [JsonConstructor]
        public AchievementCriteria(int id, string description, int amount)
        {
            Id = id;
            Description = description;
            Amount = amount;
        }
    }
}
