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
        /// Gets the enchantment ID for the enchantment.
        /// </summary>
        [JsonPropertyName("enchantment_id")]
        public int EnchantmentId { get; set; }

        /// <summary>
        /// Gets a reference to the item.
        /// </summary>
        [JsonPropertyName("source_item")]
        public ItemReference SourceItem { get; set; }
    }
}
