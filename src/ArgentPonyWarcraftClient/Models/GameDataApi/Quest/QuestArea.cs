using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A quest area.
    /// </summary>
    public record QuestArea
    {
        /// <summary>
        /// Gets links for the quest area.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the quest area.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the quest area name.
        /// </summary>
        [JsonPropertyName("area")]
        public string Area { get; }

        /// <summary>
        /// Gets references to the quests in this area.
        /// </summary>
        [JsonPropertyName("quests")]
        public QuestReference[] Quests { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestArea"/> class.
        /// </summary>
        /// <param name="links">Links for the quest area.</param>
        /// <param name="id">The ID of the quest area.</param>
        /// <param name="area">The quest area name.</param>
        /// <param name="quests">References to the quests in this area.</param>
        [JsonConstructor]
        public QuestArea(Links links, int id, string area, QuestReference[] quests)
        {
            Links = links;
            Id = id;
            Area = area;
            Quests = quests;
        }
    }
}
