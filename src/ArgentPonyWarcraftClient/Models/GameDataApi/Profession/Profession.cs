using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A profession.
    /// </summary>
    public class Profession
    {
        /// <summary>
        /// Gets links for the profession.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the profession.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the profession.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets a description of the profession.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets the type of the profession.
        /// </summary>
        [JsonProperty("type")]
        public EnumType Type { get; set; }

        /// <summary>
        /// Gets media associated with the profession.
        /// </summary>
        [JsonProperty("media")]
        public Media Media { get; set; }

        /// <summary>
        /// Gets references to the skill tiers for the profession.
        /// </summary>
        [JsonProperty("skill_tiers")]
        public SkillTierReference[] SkillTiers { get; set; }
    }
}
