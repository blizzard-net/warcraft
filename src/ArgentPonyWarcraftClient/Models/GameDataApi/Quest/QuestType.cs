using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A quest type (such as PvP quests, raid quests, or account quests).
    /// </summary>
    public class QuestType
    {
        /// <summary>
        /// Gets links for the quest type.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the quest type.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the quest type name.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets references to the quests of this type.
        /// </summary>
        [JsonProperty("quests")]
        public QuestReference[] Quests { get; set; }
    }
}
