using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A quest area.
    /// </summary>
    public class QuestArea
    {
        /// <summary>
        /// Gets links for the quest area.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the quest area.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the quest area name.
        /// </summary>
        [JsonPropertyName("area")]
        public string Area { get; set; }

        /// <summary>
        /// Gets references to the quests in this area.
        /// </summary>
        [JsonPropertyName("quests")]
        public QuestReference[] Quests { get; set; }
    }
}
