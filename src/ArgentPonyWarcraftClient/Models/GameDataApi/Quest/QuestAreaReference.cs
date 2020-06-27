using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a quest area.
    /// </summary>
    public class QuestAreaReference
    {
        /// <summary>
        /// Gets the key for the quest area.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the quest area.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the quest area.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
