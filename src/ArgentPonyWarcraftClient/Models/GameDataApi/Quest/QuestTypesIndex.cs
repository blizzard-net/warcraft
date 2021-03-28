using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of quest types (such as PvP quests, raid quests, or account quests).
    /// </summary>
    public class QuestTypesIndex
    {
        /// <summary>
        /// Gets links for the index of quest types.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the quest types.
        /// </summary>
        [JsonPropertyName("types")]
        public QuestTypeReference[] Types { get; set; }
    }
}
