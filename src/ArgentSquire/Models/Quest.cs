using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// A quest.
    /// </summary>
    public class Quest
    {
        /// <summary>
        /// Gets or sets the quest ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the required level.
        /// </summary>
        [JsonProperty("reqLevel")]
        public int RequiredLevel { get; set; }

        /// <summary>
        /// Gets or sets the suggested number of party members.
        /// </summary>
        [JsonProperty("suggestedPartyMembers")]
        public int SuggestedPartyMembers { get; set; }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the level.
        /// </summary>
        [JsonProperty("level")]
        public int Level { get; set; }
    }
}
