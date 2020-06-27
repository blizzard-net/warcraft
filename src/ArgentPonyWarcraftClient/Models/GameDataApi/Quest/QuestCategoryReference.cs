using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a quest category.
    /// </summary>
    public class QuestCategoryReference
    {
        /// <summary>
        /// Gets the key for the quest category.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the quest category.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the quest category.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
