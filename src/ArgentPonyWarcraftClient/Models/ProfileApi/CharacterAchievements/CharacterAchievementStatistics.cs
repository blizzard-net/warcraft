using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character's statistics as they pertain to achievements.
    /// </summary>
    public class CharacterAchievementStatistics
    {
        /// <summary>
        /// Gets links for the character achievement statistics.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonProperty("character")]
        public CharacterReference Character { get; set; }

        /// <summary>
        /// Get the character achievement statistic categories.
        /// </summary>
        [JsonProperty("categories")]
        public Category[] Categories { get; set; }
    }
}
