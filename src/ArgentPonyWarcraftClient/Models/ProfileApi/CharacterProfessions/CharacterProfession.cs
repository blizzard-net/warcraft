using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character's profession.
    /// </summary>
    public class CharacterProfession
    {
        /// <summary>
        /// Gets a reference to the profession.
        /// </summary>
        [JsonProperty("profession")]
        public ProfessionReference Profession { get; set; }

        /// <summary>
        /// Gets the skill tiers for t
        /// </summary>
        [JsonProperty("tiers")]
        public CharacterSkillTier[] Tiers { get; set; }

        /// <summary>
        /// Gets the character's skill points in this profession.
        /// </summary>
        [JsonProperty("skill_points", NullValueHandling = NullValueHandling.Ignore)]
        public long? SkillPoints { get; set; }

        /// <summary>
        /// Gets the character's maximum skill points in this profession.
        /// </summary>
        [JsonProperty("max_skill_points", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxSkillPoints { get; set; }
    }
}
