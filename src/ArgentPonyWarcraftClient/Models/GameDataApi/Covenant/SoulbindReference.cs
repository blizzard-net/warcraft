using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a soulbind.
    /// </summary>
    public class SoulbindReference
    {
        /// <summary>
        /// Gets the key for the soulbind.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the soulbind.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the soulbind.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
