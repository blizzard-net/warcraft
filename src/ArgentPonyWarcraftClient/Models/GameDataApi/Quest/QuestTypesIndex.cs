using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the quest types.
        /// </summary>
        [JsonProperty("types")]
        public QuestTypeReference[] Types { get; set; }
    }
}
