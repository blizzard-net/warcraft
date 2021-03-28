using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character's statistics as they pertain to achievements.
    /// </summary>
    public record CharacterAchievementStatistics
    {
        /// <summary>
        /// Gets links for the character achievement statistics.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonPropertyName("character")]
        public CharacterReference Character { get; }

        /// <summary>
        /// Get the character achievement statistic categories.
        /// </summary>
        [JsonPropertyName("categories")]
        public Category[] Categories { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterAchievementStatistics"/> class.
        /// </summary>
        /// <param name="links">Links for the character achievement statistics.</param>
        /// <param name="character">A reference to the character.</param>
        /// <param name="categories">A reference to the character.</param>
        [JsonConstructor]
        public CharacterAchievementStatistics(Links links, CharacterReference character, Category[] categories)
        {
            Links = links;
            Character = character;
            Categories = categories;
        }
    }
}
