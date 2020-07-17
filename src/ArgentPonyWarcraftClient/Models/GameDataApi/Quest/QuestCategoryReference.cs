using System.Text.Json.Serialization;

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
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the quest category.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the quest category.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
