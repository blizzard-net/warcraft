using System.Text.Json.Serialization;

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
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the quest category.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets the quest category name.
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// Gets references to the quests in this category.
        /// </summary>
        [JsonPropertyName("quests")]
        public QuestReference[] Quests { get; set; }
    }
}
