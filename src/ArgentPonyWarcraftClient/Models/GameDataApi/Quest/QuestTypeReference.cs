using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a quest type.
    /// </summary>
    public class QuestTypeReference
    {
        /// <summary>
        /// Gets the key for the quest type.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the quest type.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the quest type.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
