using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character's skill tier within a profession.
    /// </summary>
    public record CharacterSkillTier
    {
        /// <summary>
        /// Gets the character's skill points in this profession skill tier.
        /// </summary>
        [JsonPropertyName("skill_points")]
        public int SkillPoints { get; }

        /// <summary>
        /// Gets the maximum possible skill points in this profession skill tier.
        /// </summary>
        [JsonPropertyName("max_skill_points")]
        public int MaxSkillPoints { get; }

        /// <summary>
        /// Gets a reference to the skill tier.
        /// </summary>
        [JsonPropertyName("tier")]
        public SkillTierReferenceWithoutKey Tier { get; }

        /// <summary>
        /// Gets references to the known recipes for this profession skill tier.
        /// </summary>
        [JsonPropertyName("known_recipes")]
        public RecipeReference[] KnownRecipes { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterSkillTier"/> class.
        /// </summary>
        /// <param name="skillPoints">The character's skill points in this profession skill tier.</param>
        /// <param name="maxSkillPoints">The maximum possible skill points in this profession skill tier.</param>
        /// <param name="tier">A reference to the skill tier.</param>
        /// <param name="knownRecipes">References to the known recipes for this profession skill tier.</param>
        [JsonConstructor]
        public CharacterSkillTier(int skillPoints, int maxSkillPoints, SkillTierReferenceWithoutKey tier, RecipeReference[] knownRecipes)
        {
            SkillPoints = skillPoints;
            MaxSkillPoints = maxSkillPoints;
            Tier = tier;
            KnownRecipes = knownRecipes;
        }
    }
}
