using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to any achievement.
    /// </summary>
    public class AchievementReference
    {
        /// <summary>
        /// Gets the key for this achievement.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; private set; }

        /// <summary>
        /// Gets the name of this achievement.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the ID of this achievement.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; private set; }
    }
}
