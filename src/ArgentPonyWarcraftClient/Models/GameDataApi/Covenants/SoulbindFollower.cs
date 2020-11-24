using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A follower for a soulbind.
    /// </summary>
    public class SoulbindFollower
    {
        /// <summary>
        /// Gets the Id of the follower.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets the name of the follower.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
