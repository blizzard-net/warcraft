using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Item preview data.
    /// </summary>
    public class PreviewItem
    {
        /// <summary>
        /// Gets a reference to the item.
        /// </summary>
        [JsonPropertyName("item")]
        public Media Item { get; set; }

        /// <summary>
        /// Gets the quality of the item.
        /// </summary>
        [JsonPropertyName("quality")]
        public EnumType Quality { get; set; }

        /// <summary>
        /// Gets the name of the item.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the media associated with this item.
        /// </summary>
        [JsonPropertyName("media")]
        public Media Media { get; set; }

        /// <summary>
        /// Gets a reference to the item class.
        /// </summary>
        [JsonPropertyName("item_class")]
        public ItemClassReference ItemClass { get; set; }

        /// <summary>
        /// Gets a reference to the item subclass.
        /// </summary>
        [JsonPropertyName("item_subclass")]
        public ItemSubclassReference ItemSubclass { get; set; }

        /// <summary>
        /// Gets the inventory type for the item.
        /// </summary>
        [JsonPropertyName("inventory_type")]
        public EnumType InventoryType { get; set; }

        /// <summary>
        /// Gets the binding type for the item.
        /// </summary>
        [JsonPropertyName("binding")]
        public EnumType Binding { get; set; }

        /// <summary>
        /// Gets an indication of whether the item is unique-equipped.
        /// </summary>
        [JsonPropertyName("unique_equipped")]
        public string UniqueEquipped { get; set; }

        /// <summary>
        /// Gets weapon information for the item.
        /// </summary>
        [JsonPropertyName("weapon")]
        public Weapon Weapon { get; set; }

        /// <summary>
        /// Gets the stats associated with the item.
        /// </summary>
        [JsonPropertyName("stats")]
        public Stat[] Stats { get; set; }

        /// <summary>
        /// Gets the spells associated with the item.
        /// </summary>
        [JsonPropertyName("spells")]
        public ItemSpell[] Spells { get; set; }

        /// <summary>
        /// Gets the sell price of the item.
        /// </summary>
        [JsonPropertyName("sell_price")]
        public SellPrice SellPrice { get; set; }

        /// <summary>
        /// Gets the level requiements for using an item.
        /// </summary>
        [JsonPropertyName("requirements")]
        public Requirements Requirements { get; set; }

        /// <summary>
        /// Gets the item level.
        /// </summary>
        [JsonPropertyName("level")]
        public DescribedValue Level { get; set; }

        /// <summary>
        /// Gets the durability of the item.
        /// </summary>
        [JsonPropertyName("durability")]
        public DescribedValue Durability { get; set; }
    }
}
