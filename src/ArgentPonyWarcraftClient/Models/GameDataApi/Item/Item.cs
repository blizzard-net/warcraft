using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An item.
    /// </summary>
    public record Item
    {
        /// <summary>
        /// Gets links for the item.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the item.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of the item.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the item quality.
        /// </summary>
        [JsonPropertyName("quality")]
        public EnumType Quality { get; }

        /// <summary>
        /// Gets the item level of the item.
        /// </summary>
        [JsonPropertyName("level")]
        public int Level { get; }

        /// <summary>
        /// Gets the required character level for using the item.
        /// </summary>
        [JsonPropertyName("required_level")]
        public int RequiredLevel { get; }

        /// <summary>
        /// Gets the media associated with this item.
        /// </summary>
        [JsonPropertyName("media")]
        public Media Media { get; }

        /// <summary>
        /// Gets a reference to the item class.
        /// </summary>
        [JsonPropertyName("item_class")]
        public ItemClassReference ItemClass { get; }

        /// <summary>
        /// Gets a reference to the item subclass.
        /// </summary>
        [JsonPropertyName("item_subclass")]
        public ItemSubclassReference ItemSubclass { get; }

        /// <summary>
        /// Gets the inventory type for the item.
        /// </summary>
        [JsonPropertyName("inventory_type")]
        public EnumType InventoryType { get; }

        /// <summary>
        /// Gets the purchase price of the item.
        /// </summary>
        [JsonPropertyName("purchase_price")]
        public long PurchasePrice { get; }

        /// <summary>
        /// Gets the vendor sell price of the item.
        /// </summary>
        [JsonPropertyName("sell_price")]
        public long SellPrice { get; }

        /// <summary>
        /// Gets the maximum count of the item, which applies to stackable items.
        /// </summary>
        [JsonPropertyName("max_count")]
        public int MaxCount { get; }

        /// <summary>
        /// Gets a value indicating whether the item can be equipped.
        /// </summary>
        [JsonPropertyName("is_equippable")]
        public bool IsEquippable { get; }

        /// <summary>
        /// Gets a value indicating whether the item can be stacked in inventory.
        /// </summary>
        [JsonPropertyName("is_stackable")]
        public bool IsStackable { get; }

        /// <summary>
        /// Gets item preview data.
        /// </summary>
        [JsonPropertyName("preview_item")]
        public PreviewItem PreviewItem { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        /// <param name="links">Links for the item.</param>
        /// <param name="id">The ID of the item.</param>
        /// <param name="name">The name of the item.</param>
        /// <param name="quality">The item quality.</param>
        /// <param name="level">The item level of the item.</param>
        /// <param name="requiredLevel">The required character level for using the item.</param>
        /// <param name="media">The media associated with this item.</param>
        /// <param name="itemClass">A reference to the item class.</param>
        /// <param name="itemSubclass">A reference to the item subclass.</param>
        /// <param name="inventoryType">The inventory type for the item.</param>
        /// <param name="purchasePrice">The purchase price of the item.</param>
        /// <param name="sellPrice">The vendor sell price of the item.</param>
        /// <param name="maxCount">The maximum count of the item, which applies to stackable items.</param>
        /// <param name="isEquippable">A value indicating whether the item can be equipped.</param>
        /// <param name="isStackable">A value indicating whether the item can be stacked in inventory.</param>
        /// <param name="previewItem">Item preview data.</param>
        [JsonConstructor]
        public Item(Links links, int id, string name, EnumType quality, int level, int requiredLevel, Media media, ItemClassReference itemClass, ItemSubclassReference itemSubclass, EnumType inventoryType, long purchasePrice, long sellPrice, int maxCount, bool isEquippable, bool isStackable, PreviewItem previewItem)
        {
            Links = links;
            Id = id;
            Name = name;
            Quality = quality;
            Level = level;
            RequiredLevel = requiredLevel;
            Media = media;
            ItemClass = itemClass;
            ItemSubclass = itemSubclass;
            InventoryType = inventoryType;
            PurchasePrice = purchasePrice;
            SellPrice = sellPrice;
            MaxCount = maxCount;
            IsEquippable = isEquippable;
            IsStackable = isStackable;
            PreviewItem = previewItem;
        }
    }
}
