using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A skill tier for a profession.
    /// </summary>
    public record SkillTier
    {
        /// <summary>
        /// Gets links for the skill tier.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the skill tier.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of the skill tier.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the minimum skill level for the skill tier.
        /// </summary>
        [JsonPropertyName("minimum_skill_level")]
        public int MinimumSkillLevel { get; }

        /// <summary>
        /// Gets the maximum skill level for the skill tier.
        /// </summary>
        [JsonPropertyName("maximum_skill_level")]
        public int MaximumSkillLevel { get; }

        /// <summary>
        /// Gets the categories in the skill tier.
        /// </summary>
        [JsonPropertyName("categories")]
        public RecipeCategory[] Categories { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillTier"/> class.
        /// </summary>
        /// <param name="links">Links for the skill tier.</param>
        /// <param name="id">The ID of the skill tier.</param>
        /// <param name="name">The name of the skill tier.</param>
        /// <param name="minimumSkillLevel">The minimum skill level for the skill tier.</param>
        /// <param name="maximumSkillLevel">The maximum skill level for the skill tier.</param>
        /// <param name="categories">The categories in the skill tier.</param>
        [JsonConstructor]
        public SkillTier(Links links, int id, string name, int minimumSkillLevel, int maximumSkillLevel, RecipeCategory[] categories)
        {
            Links = links;
            Id = id;
            Name = name;
            MinimumSkillLevel = minimumSkillLevel;
            MaximumSkillLevel = maximumSkillLevel;
            Categories = categories;
        }
    }
}
