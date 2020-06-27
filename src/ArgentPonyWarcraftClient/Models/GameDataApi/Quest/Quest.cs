using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the quest.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the title of the quest.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets a reference to the area for the quest.
        /// </summary>
        [JsonProperty("area")]
        public QuestAreaReference Area { get; set; }

        /// <summary>
        /// Gets the description of the quest.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets the recommended minimum level for the quest.
        /// </summary>
        [JsonProperty("recommended_minimum_level")]
        public long RecommendedMinimumLevel { get; set; }

        /// <summary>
        /// Gets the recommended maximum level for the quest.
        /// </summary>
        [JsonProperty("recommended_maximum_level")]
        public long RecommendedMaximumLevel { get; set; }

        /// <summary>
        /// Gets the requirements for the quest.
        /// </summary>
        [JsonProperty("requirements")]
        public QuestRequirements Requirements { get; set; }

        /// <summary>
        /// Gets the quest rewards.
        /// </summary>
        [JsonProperty("rewards")]
        public QuestReward Rewards { get; set; }
    }
}
