using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character's profession.
    /// </summary>
    public record CharacterProfession
    {
        /// <summary>
        /// Gets a reference to the profession.
        /// </summary>
        [JsonPropertyName("profession")]
        public ProfessionReference Profession { get; }

        /// <summary>
        /// Gets the skill tiers for t
        /// </summary>
        [JsonPropertyName("tiers")]
        public CharacterSkillTier[] Tiers { get; }

        /// <summary>
        /// Gets the character's skill points in this profession.
        /// </summary>
        [JsonPropertyName("skill_points")]
        public int? SkillPoints { get; }

        /// <summary>
        /// Gets the character's maximum skill points in this profession.
        /// </summary>
        [JsonPropertyName("max_skill_points")]
        public int? MaxSkillPoints { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterProfession"/> class.
        /// </summary>
        /// <param name="profession">A reference to the profession.</param>
        /// <param name="tiers">The skill tiers for t</param>
        /// <param name="skillPoints">The character's skill points in this profession.</param>
        /// <param name="maxSkillPoints">The character's maximum skill points in this profession.</param>
        [JsonConstructor]
        public CharacterProfession(ProfessionReference profession, CharacterSkillTier[] tiers, int? skillPoints, int? maxSkillPoints)
        {
            Profession = profession;
            Tiers = tiers;
            SkillPoints = skillPoints;
            MaxSkillPoints = maxSkillPoints;
        }
    }
}
