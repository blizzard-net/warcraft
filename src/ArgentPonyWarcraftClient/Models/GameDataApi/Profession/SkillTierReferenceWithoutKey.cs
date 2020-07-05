using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a skill tier.
    /// </summary>
    public class SkillTierReferenceWithoutKey
    {
        /// <summary>
        /// Gets the name of the skill tier.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the skill tier.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
