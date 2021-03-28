using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to an item set.
    /// </summary>
    public class ItemSetReference
    {
        /// <summary>
        /// Gets the key for the item set.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the item set.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the item set.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
