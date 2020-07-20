using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An achievement category.
    /// </summary>
    public class AchievementCategory
    {
        /// <summary>
        /// Gets links for this achievement category.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; private set; }

        /// <summary>
        /// Gets the ID of this achievement category.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; private set; }

        /// <summary>
        /// Gets the name of this achievement category.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets references to the achievements in this category.
        /// </summary>
        [JsonPropertyName("achievements")]
        public AchievementReference[] Achievements { get; private set; }

        /// <summary>
        /// Gets references to subcategories of this achievement category.
        /// </summary>
        [JsonPropertyName("subcategories")]
        public AchievementCategoryReference[] Subcategories { get; private set; }

        /// <summary>
        /// Gets a value that indicates whether this is a guild category.
        /// </summary>
        [JsonPropertyName("is_guild_category")]
        public bool IsGuildCategory { get; private set; }

        /// <summary>
        /// Gets the aggregates by faction.
        /// </summary>
        [JsonPropertyName("aggregates_by_faction")]
        public AggregatesByFaction AggregatesByFaction { get; private set; }

        /// <summary>
        /// Gets the display order.
        /// </summary>
        [JsonPropertyName("display_order")]
        public int DisplayOrder { get; private set; }
    }
}
