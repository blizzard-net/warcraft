using System.Text.Json.Serialization;

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
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the skill tier.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the skill tier.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
