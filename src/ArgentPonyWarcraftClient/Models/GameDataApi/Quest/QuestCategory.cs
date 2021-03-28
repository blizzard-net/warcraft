using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A quest category.
    /// </summary>
    public record QuestCategory
    {
        /// <summary>
        /// Gets links for the quest category.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the quest category.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the quest category name.
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; }

        /// <summary>
        /// Gets references to the quests in this category.
        /// </summary>
        [JsonPropertyName("quests")]
        public QuestReference[] Quests { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestCategory"/> class.
        /// </summary>
        /// <param name="links">Links for the quest category.</param>
        /// <param name="id">The ID of the quest category.</param>
        /// <param name="category">The quest category name.</param>
        /// <param name="quests">References to the quests in this category.</param>
        [JsonConstructor]
        public QuestCategory(Links links, int id, string category, QuestReference[] quests)
        {
            Links = links;
            Id = id;
            Category = category;
            Quests = quests;
        }
    }
}
