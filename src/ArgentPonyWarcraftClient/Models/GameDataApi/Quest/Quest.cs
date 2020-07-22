using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A quest.
    /// </summary>
    public class Quest
    {
        /// <summary>
        /// Gets links for the quest.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the quest.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets the title of the quest.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets a reference to the area for the quest.
        /// </summary>
        [JsonPropertyName("area")]
        public QuestAreaReference Area { get; set; }

        /// <summary>
        /// Gets the description of the quest.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets the recommended minimum level for the quest.
        /// </summary>
        [JsonPropertyName("recommended_minimum_level")]
        public int RecommendedMinimumLevel { get; set; }

        /// <summary>
        /// Gets the recommended maximum level for the quest.
        /// </summary>
        [JsonPropertyName("recommended_maximum_level")]
        public int RecommendedMaximumLevel { get; set; }

        /// <summary>
        /// Gets the requirements for the quest.
        /// </summary>
        [JsonPropertyName("requirements")]
        public QuestRequirements Requirements { get; set; }

        /// <summary>
        /// Gets the quest rewards.
        /// </summary>
        [JsonPropertyName("rewards")]
        public QuestReward Rewards { get; set; }
    }
}
