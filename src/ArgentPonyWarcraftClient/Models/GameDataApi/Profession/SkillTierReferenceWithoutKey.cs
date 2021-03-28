using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a skill tier.
    /// </summary>
    public record SkillTierReferenceWithoutKey
    {
        /// <summary>
        /// Gets the name of the skill tier.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the skill tier.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillTierReferenceWithoutKey"/> class.
        /// </summary>
        /// <param name="name">The name of the skill tier.</param>
        /// <param name="id">The ID of the skill tier.</param>
        [JsonConstructor]
        public SkillTierReferenceWithoutKey(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}
