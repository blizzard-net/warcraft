using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An achievement category.
    /// </summary>
    public record AchievementCategory
    {
        /// <summary>
        /// Gets links for this achievement category.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of this achievement category.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of this achievement category.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets references to the achievements in this category.
        /// </summary>
        [JsonPropertyName("achievements")]
        public AchievementReference[] Achievements { get; }

        /// <summary>
        /// Gets references to subcategories of this achievement category.
        /// </summary>
        [JsonPropertyName("subcategories")]
        public AchievementCategoryReference[] Subcategories { get; }

        /// <summary>
        /// Gets a value that indicates whether this is a guild category.
        /// </summary>
        [JsonPropertyName("is_guild_category")]
        public bool IsGuildCategory { get; }

        /// <summary>
        /// Gets the aggregates by faction.
        /// </summary>
        [JsonPropertyName("aggregates_by_faction")]
        public AggregatesByFaction AggregatesByFaction { get; }

        /// <summary>
        /// Gets the display order.
        /// </summary>
        [JsonPropertyName("display_order")]
        public int DisplayOrder { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AchievementCategory"/> class.
        /// </summary>
        /// <param name="links">Links for this achievement category.</param>
        /// <param name="id">The ID of this achievement category.</param>
        /// <param name="name">The name of this achievement category.</param>
        /// <param name="achievements">References to the achievements in this category.</param>
        /// <param name="subcategories">References to subcategories of this achievement category.</param>
        /// <param name="isGuildCategory">A value that indicates whether this is a guild category.</param>
        /// <param name="aggregatesByFaction">The aggregates by faction.</param>
        /// <param name="displayOrder">The display order.</param>
        [JsonConstructor]
        public AchievementCategory(Links links, int id, string name, AchievementReference[] achievements, AchievementCategoryReference[] subcategories, bool isGuildCategory, AggregatesByFaction aggregatesByFaction, int displayOrder)
        {
            Links = links;
            Id = id;
            Name = name;
            Achievements = achievements;
            Subcategories = subcategories;
            IsGuildCategory = isGuildCategory;
            AggregatesByFaction = aggregatesByFaction;
            DisplayOrder = displayOrder;
        }
    }
}
