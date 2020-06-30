using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A summary of the achievements a character has completed.
    /// </summary>
    public class CharacterAchievementsSummary
    {
        /// <summary>
        /// Gets links for the character achievements summary.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the total number of achievements for this character.
        /// </summary>
        [JsonProperty("total_quantity")]
        public long TotalQuantity { get; set; }

        /// <summary>
        /// Gets the total number of achievement points for this character.
        /// </summary>
        [JsonProperty("total_points")]
        public long TotalPoints { get; set; }

        /// <summary>
        /// Gets the achievements for this character.
        /// </summary>
        [JsonProperty("achievements")]
        public CharacterAchievement[] Achievements { get; set; }

        /// <summary>
        /// Gets the character's progress in various achievement categories.
        /// </summary>
        [JsonProperty("category_progress")]
        public CategoryProgress[] CategoryProgress { get; set; }

        /// <summary>
        /// Gets recent achievements by the character.
        /// </summary>
        [JsonProperty("recent_events")]
        public RecentEvent[] RecentEvents { get; set; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonProperty("character")]
        public CharacterReference Character { get; set; }

        /// <summary>
        /// Gets a link to the character's achievement statistics.
        /// </summary>
        [JsonProperty("statistics")]
        public Self Statistics { get; set; }
    }
}
