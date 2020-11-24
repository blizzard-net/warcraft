using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a soulbind.
    /// </summary>
    public class SoulbindReference
    {
        /// <summary>
        /// Gets the key for this soulbind.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the Id for this soulbind.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets the name for this soulbind.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
