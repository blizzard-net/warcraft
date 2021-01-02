using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An Enchantment.
    /// </summary>
    public class Enchantment
    {
        /// <summary>
        /// Gets the display string for the enchantment.
        /// </summary>
        [JsonPropertyName("display_string")]
        public string DisplayString { get; set; }

        /// <summary>
        /// Gets the enchantment_id for the enchantment.
        /// </summary>
        [JsonPropertyName("enchantment_id")]
        public int enchantment_id { get; set; }

        /// <summary>
        /// Gets a reference to the item.
        /// </summary>
        [JsonPropertyName("source_item")]
        public ItemReference Item { get; set; }

    }
}
