using System.Text.Json.Serialization;

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
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the total number of achievements for this character.
        /// </summary>
        [JsonPropertyName("total_quantity")]
        public int TotalQuantity { get; set; }

        /// <summary>
        /// Gets the total number of achievement points for this character.
        /// </summary>
        [JsonPropertyName("total_points")]
        public int TotalPoints { get; set; }

        /// <summary>
        /// Gets the achievements for this character.
        /// </summary>
        [JsonPropertyName("achievements")]
        public AchievementProgress[] Achievements { get; set; }

        /// <summary>
        /// Gets the character's progress in various achievement categories.
        /// </summary>
        [JsonPropertyName("category_progress")]
        public CategoryProgress[] CategoryProgress { get; set; }

        /// <summary>
        /// Gets recent achievements by the character.
        /// </summary>
        [JsonPropertyName("recent_events")]
        public RecentEvent[] RecentEvents { get; set; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonPropertyName("character")]
        public CharacterReference Character { get; set; }

        /// <summary>
        /// Gets a link to the character's achievement statistics.
        /// </summary>
        [JsonPropertyName("statistics")]
        public Self Statistics { get; set; }
    }
}
