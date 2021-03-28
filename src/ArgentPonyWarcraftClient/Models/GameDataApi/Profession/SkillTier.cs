using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A skill tier for a profession.
    /// </summary>
    public class SkillTier
    {
        /// <summary>
        /// Gets links for the skill tier.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the skill tier.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets the name of the skill tier.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the minimum skill level for the skill tier.
        /// </summary>
        [JsonPropertyName("minimum_skill_level")]
        public int MinimumSkillLevel { get; set; }

        /// <summary>
        /// Gets the maximum skill level for the skill tier.
        /// </summary>
        [JsonPropertyName("maximum_skill_level")]
        public int MaximumSkillLevel { get; set; }

        /// <summary>
        /// Gets the categories in the skill tier.
        /// </summary>
        [JsonPropertyName("categories")]
        public RecipeCategory[] Categories { get; set; }
    }
}
