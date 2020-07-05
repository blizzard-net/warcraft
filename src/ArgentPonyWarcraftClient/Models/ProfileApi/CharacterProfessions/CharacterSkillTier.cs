using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character's skill tier within a profession.
    /// </summary>
    public class CharacterSkillTier
    {
        /// <summary>
        /// Gets the character's skill points in this profession skill tier.
        /// </summary>
        [JsonProperty("skill_points")]
        public long SkillPoints { get; set; }

        /// <summary>
        /// Gets the maximum possible skill points in this profession skill tier.
        /// </summary>
        [JsonProperty("max_skill_points")]
        public long MaxSkillPoints { get; set; }

        /// <summary>
        /// Gets a reference to the skill tier.
        /// </summary>
        [JsonProperty("tier")]
        public SkillTierReferenceWithoutKey Tier { get; set; }

        /// <summary>
        /// Gets references to the known recipes for this profession skill tier.
        /// </summary>
        [JsonProperty("known_recipes", NullValueHandling = NullValueHandling.Ignore)]
        public RecipeReference[] KnownRecipes { get; set; }
    }
}
