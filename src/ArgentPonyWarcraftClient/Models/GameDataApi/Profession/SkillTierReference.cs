using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a skill tier.
    /// </summary>
    public class SkillTierReference
    {
        /// <summary>
        /// Gets the key for the skill tier.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

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
