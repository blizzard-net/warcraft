using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An Enchantment.
    /// </summary>
    public record Enchantment
    {
        /// <summary>
        /// Gets the display string for the enchantment.
        /// </summary>
        [JsonPropertyName("display_string")]
        public string DisplayString { get; }

        /// <summary>
        /// Gets the enchantment ID for the enchantment.
        /// </summary>
        [JsonPropertyName("enchantment_id")]
        public int EnchantmentId { get; }

        /// <summary>
        /// Gets a reference to the item.
        /// </summary>
        [JsonPropertyName("source_item")]
        public ItemReference SourceItem { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Enchantment"/> class.
        /// </summary>
        /// <param name="displayString">The display string for the enchantment.</param>
        /// <param name="enchantmentId">The enchantment ID for the enchantment.</param>
        /// <param name="sourceItem">A reference to the item.</param>
        [JsonConstructor]
        public Enchantment(string displayString, int enchantmentId, ItemReference sourceItem)
        {
            DisplayString = displayString;
            EnchantmentId = enchantmentId;
            SourceItem = sourceItem;
        }
    }
}
