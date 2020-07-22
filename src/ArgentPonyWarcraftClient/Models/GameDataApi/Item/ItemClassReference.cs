using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to an item class.
    /// </summary>
    public class ItemClassReference
    {
        /// <summary>
        /// Gets the key for the item class.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the item class.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the item class.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
