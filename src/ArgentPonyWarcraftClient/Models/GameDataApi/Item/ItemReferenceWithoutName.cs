using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to an item.
    /// </summary>
    public class ItemReferenceWithoutName
    {
        /// <summary>
        /// Gets the key for the item.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the ID of the item.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
