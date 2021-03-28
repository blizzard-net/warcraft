using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to an item subclass.
    /// </summary>
    public class ItemSubclassReference
    {
        /// <summary>
        /// Gets the key for the item subclass.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the item subclass.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the item subclass.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
