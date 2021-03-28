using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a skill tier.
    /// </summary>
    public record SkillTierReference
    {
        /// <summary>
        /// Gets the key for the skill tier.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

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
        /// Initializes a new instance of the <see cref="SkillTierReference"/> class.
        /// </summary>
        /// <param name="key">The key for the skill tier.</param>
        /// <param name="name">The name of the skill tier.</param>
        /// <param name="id">The ID of the skill tier.</param>
        [JsonConstructor]
        public SkillTierReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
