using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// An achievement category.
    /// </summary>
    public class AchievementCategory
    {
        /// <summary>
        /// Gets links for this achievement category.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; private set; }

        /// <summary>
        /// Gets the ID of this achievement category.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; private set; }

        /// <summary>
        /// Gets the name of this achievement category.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets references to the achievements in this category.
        /// </summary>
        [JsonProperty("achievements")]
        public AchievementReference[] Achievements { get; private set; }

        /// <summary>
        /// Gets references to subcategories of this achievement category.
        /// </summary>
        [JsonProperty("subcategories")]
        public AchievementCategoryReference[] Subcategories { get; private set; }

        /// <summary>
        /// Gets a value that indicates whether this is a guild category.
        /// </summary>
        [JsonProperty("is_guild_category")]
        public bool IsGuildCategory { get; private set; }

        /// <summary>
        /// Gets the aggregates by faction.
        /// </summary>
        [JsonProperty("aggregates_by_faction")]
        public AggregatesByFaction AggregatesByFaction { get; private set; }

        /// <summary>
        /// Gets the display order.
        /// </summary>
        [JsonProperty("display_order")]
        public int DisplayOrder { get; private set; }
    }
}
