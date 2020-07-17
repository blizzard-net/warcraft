using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An item.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Gets links for the item.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the item.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the item.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the item quality.
        /// </summary>
        [JsonPropertyName("quality")]
        public EnumType Quality { get; set; }

        /// <summary>
        /// Gets the item level of the item.
        /// </summary>
        [JsonPropertyName("level")]
        public long Level { get; set; }

        /// <summary>
        /// Gets the required character level for using the item.
        /// </summary>
        [JsonPropertyName("required_level")]
        public long RequiredLevel { get; set; }

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
        /// Gets the purchase price of the item.
        /// </summary>
        [JsonPropertyName("purchase_price")]
        public long PurchasePrice { get; set; }

        /// <summary>
        /// Gets the vendor sell price of the item.
        /// </summary>
        [JsonPropertyName("sell_price")]
        public long SellPrice { get; set; }

        /// <summary>
        /// Gets the maximum count of the item, which applies to stackable items.
        /// </summary>
        [JsonPropertyName("max_count")]
        public long MaxCount { get; set; }

        /// <summary>
        /// Gets a value indicating whether the item can be equipped.
        /// </summary>
        [JsonPropertyName("is_equippable")]
        public bool IsEquippable { get; set; }

        /// <summary>
        /// Gets a value indicating whether the item can be stacked in inventory.
        /// </summary>
        [JsonPropertyName("is_stackable")]
        public bool IsStackable { get; set; }

        /// <summary>
        /// Gets item preview data.
        /// </summary>
        [JsonPropertyName("preview_item")]
        public PreviewItem PreviewItem { get; set; }
    }
}
