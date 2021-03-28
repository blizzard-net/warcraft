using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to any achievement.
    /// </summary>
    public record AchievementReference
    {
        /// <summary>
        /// Gets the key for this achievement.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of this achievement.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of this achievement.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AchievementReference"/> class.
        /// </summary>
        /// <param name="key">The key for this achievement.</param>
        /// <param name="name">The name of this achievement.</param>
        /// <param name="id">The ID of this achievement.</param>
        [JsonConstructor]
        public AchievementReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
