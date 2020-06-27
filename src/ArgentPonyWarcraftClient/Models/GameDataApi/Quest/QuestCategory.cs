using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A quest category.
    /// </summary>
    public class QuestCategory
    {
        /// <summary>
        /// Gets links for the quest category.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the quest category.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the quest category name.
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// Gets references to the quests in this category.
        /// </summary>
        [JsonProperty("quests")]
        public QuestReference[] Quests { get; set; }
    }
}
