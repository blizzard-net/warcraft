using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the skill tier.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the skill tier.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the minimum skill level for the skill tier.
        /// </summary>
        [JsonProperty("minimum_skill_level")]
        public long MinimumSkillLevel { get; set; }

        /// <summary>
        /// Gets the maximum skill level for the skill tier.
        /// </summary>
        [JsonProperty("maximum_skill_level")]
        public long MaximumSkillLevel { get; set; }

        /// <summary>
        /// Gets the categories in the skill tier.
        /// </summary>
        [JsonProperty("categories")]
        public RecipeCategory[] Categories { get; set; }
    }
}
