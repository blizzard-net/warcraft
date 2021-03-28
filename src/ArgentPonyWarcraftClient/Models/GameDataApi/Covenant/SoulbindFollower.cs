using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A follower for a soulbind.
    /// </summary>
    public record SoulbindFollower
    {
        /// <summary>
        /// Gets the Id of the follower.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of the follower.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SoulbindFollower"/> class.
        /// </summary>
        /// <param name="id">The Id of the follower.</param>
        /// <param name="name">The name of the follower.</param>
        [JsonConstructor]
        public SoulbindFollower(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
