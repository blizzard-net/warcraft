using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the item.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the item.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the item quality.
        /// </summary>
        [JsonProperty("quality")]
        public EnumType Quality { get; set; }

        /// <summary>
        /// Gets the item level of the item.
        /// </summary>
        [JsonProperty("level")]
        public long Level { get; set; }

        /// <summary>
        /// Gets the required character level for using the item.
        /// </summary>
        [JsonProperty("required_level")]
        public long RequiredLevel { get; set; }

        /// <summary>
        /// Gets the media associated with this item.
        /// </summary>
        [JsonProperty("media")]
        public Media Media { get; set; }

        /// <summary>
        /// Gets a reference to the item class.
        /// </summary>
        [JsonProperty("item_class")]
        public ItemClassReference ItemClass { get; set; }

        /// <summary>
        /// Gets a reference to the item subclass.
        /// </summary>
        [JsonProperty("item_subclass")]
        public ItemSubclassReference ItemSubclass { get; set; }

        /// <summary>
        /// Gets the inventory type for the item.
        /// </summary>
        [JsonProperty("inventory_type")]
        public EnumType InventoryType { get; set; }

        /// <summary>
        /// Gets the purchase price of the item.
        /// </summary>
        [JsonProperty("purchase_price")]
        public long PurchasePrice { get; set; }

        /// <summary>
        /// Gets the vendor sell price of the item.
        /// </summary>
        [JsonProperty("sell_price")]
        public long SellPrice { get; set; }

        /// <summary>
        /// Gets the maximum count of the item, which applies to stackable items.
        /// </summary>
        [JsonProperty("max_count")]
        public long MaxCount { get; set; }

        /// <summary>
        /// Gets a value indicating whether the item can be equipped.
        /// </summary>
        [JsonProperty("is_equippable")]
        public bool IsEquippable { get; set; }

        /// <summary>
        /// Gets a value indicating whether the item can be stacked in inventory.
        /// </summary>
        [JsonProperty("is_stackable")]
        public bool IsStackable { get; set; }

        /// <summary>
        /// Gets item preview data.
        /// </summary>
        [JsonProperty("preview_item")]
        public PreviewItem PreviewItem { get; set; }
    }
}
