using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An achievement.
    /// </summary>
    public record Achievement
    {
        /// <summary>
        /// Gets links for this achievement.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of this achievement.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets a reference to the achievement category to which this achievement belongs.
        /// </summary>
        [JsonPropertyName("category")]
        public AchievementCategoryReference Category { get; }

        /// <summary>
        /// Gets the name of this achievement.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the description of this achievement.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; }

        /// <summary>
        /// Gets the number of achievement points associated with this achievement.
        /// </summary>
        [JsonPropertyName("points")]
        public int Points { get; }

        /// <summary>
        /// Gets a value indicating whether this achievement is account-wide.
        /// </summary>
        [JsonPropertyName("is_account_wide")]
        public bool IsAccountWide { get; }

        /// <summary>
        /// Gets the criteria for this achievement.
        /// </summary>
        [JsonPropertyName("criteria")]
        public AchievementCriteria Criteria { get; }

        /// <summary>
        /// Gets a reference to the next achievement.
        /// </summary>
        [JsonPropertyName("next_achievement")]
        public AchievementReference NextAchievement { get; }

        /// <summary>
        /// Gets the media associated with this achievement.
        /// </summary>
        [JsonPropertyName("media")]
        public Media Media { get; }

        /// <summary>
        /// Gets the display order.
        /// </summary>
        [JsonPropertyName("display_order")]
        public int DisplayOrder { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Achievement"/> class.
        /// </summary>
        /// <param name="links">Links for this achievement.</param>
        /// <param name="id">The ID of this achievement.</param>
        /// <param name="category">A reference to the achievement category to which this achievement belongs.</param>
        /// <param name="name">The name of this achievement.</param>
        /// <param name="description">The description of this achievement.</param>
        /// <param name="points">The number of achievement points associated with this achievement.</param>
        /// <param name="isAccountWide">A value indicating whether this achievement is account-wide.</param>
        /// <param name="criteria">The criteria for this achievement.</param>
        /// <param name="nextAchievement">A reference to the next achievement.</param>
        /// <param name="media">The media associated with this achievement.</param>
        /// <param name="displayOrder">The display order.</param>
        [JsonConstructor]
        public Achievement(Links links, int id, AchievementCategoryReference category, string name, string description, int points, bool isAccountWide, AchievementCriteria criteria, AchievementReference nextAchievement, Media media, int displayOrder)
        {
            Links = links;
            Id = id;
            Category = category;
            Name = name;
            Description = description;
            Points = points;
            IsAccountWide = isAccountWide;
            Criteria = criteria;
            NextAchievement = nextAchievement;
            Media = media;
            DisplayOrder = displayOrder;
        }
    }
}
