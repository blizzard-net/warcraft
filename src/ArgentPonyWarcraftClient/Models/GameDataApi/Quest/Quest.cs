using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A quest.
    /// </summary>
    public record Quest
    {
        /// <summary>
        /// Gets links for the quest.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the quest.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the title of the quest.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; }

        /// <summary>
        /// Gets a reference to the area for the quest.
        /// </summary>
        [JsonPropertyName("area")]
        public QuestAreaReference Area { get; }

        /// <summary>
        /// Gets the description of the quest.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; }

        /// <summary>
        /// Gets the recommended minimum level for the quest.
        /// </summary>
        [JsonPropertyName("recommended_minimum_level")]
        public int RecommendedMinimumLevel { get; }

        /// <summary>
        /// Gets the recommended maximum level for the quest.
        /// </summary>
        [JsonPropertyName("recommended_maximum_level")]
        public int RecommendedMaximumLevel { get; }

        /// <summary>
        /// Gets the requirements for the quest.
        /// </summary>
        [JsonPropertyName("requirements")]
        public QuestRequirements Requirements { get; }

        /// <summary>
        /// Gets the quest rewards.
        /// </summary>
        [JsonPropertyName("rewards")]
        public QuestReward Rewards { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Quest"/> class.
        /// </summary>
        /// <param name="links">Links for the quest.</param>
        /// <param name="id">The ID of the quest.</param>
        /// <param name="title">The title of the quest.</param>
        /// <param name="area">A reference to the area for the quest.</param>
        /// <param name="description">The description of the quest.</param>
        /// <param name="recommendedMinimumLevel">The recommended minimum level for the quest.</param>
        /// <param name="recommendedMaximumLevel">The recommended maximum level for the quest.</param>
        /// <param name="requirements">The requirements for the quest.</param>
        /// <param name="rewards">The quest rewards.</param>
        [JsonConstructor]
        public Quest(Links links, int id, string title, QuestAreaReference area, string description, int recommendedMinimumLevel, int recommendedMaximumLevel, QuestRequirements requirements, QuestReward rewards)
        {
            Links = links;
            Id = id;
            Title = title;
            Area = area;
            Description = description;
            RecommendedMinimumLevel = recommendedMinimumLevel;
            RecommendedMaximumLevel = recommendedMaximumLevel;
            Requirements = requirements;
            Rewards = rewards;
        }
    }
}
