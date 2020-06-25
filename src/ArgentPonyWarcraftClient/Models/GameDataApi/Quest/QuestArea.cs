namespace ArgentPonyWarcraftClient
{
    using Newtonsoft.Json;

    /// <summary>
    /// A quest area.
    /// </summary>
    public class QuestArea
    {
        /// <summary>
        /// Gets links for the quest area.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the quest area.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the quest area name.
        /// </summary>
        [JsonProperty("area")]
        public string Area { get; set; }

        /// <summary>
        /// Gets references to the quests in this area.
        /// </summary>
        [JsonProperty("quests")]
        public QuestReference[] Quests { get; set; }
    }
}
