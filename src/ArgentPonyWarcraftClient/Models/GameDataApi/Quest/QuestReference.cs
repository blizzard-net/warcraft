using System.Text.Json.Serialization;

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
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the quest.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the quest.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
