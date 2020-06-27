using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a quest.
    /// </summary>
    public class QuestReference
    {
        /// <summary>
        /// Gets the key for the quest.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the quest.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the quest.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
