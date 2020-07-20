using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to an achievement category.
    /// </summary>
    public class AchievementCategoryReference
    {
        /// <summary>
        /// Gets the key for this achievement category.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; private set; }

        /// <summary>
        /// Gets the name of this achievement category.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the ID of this achievement category.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; private set; }
    }
}
