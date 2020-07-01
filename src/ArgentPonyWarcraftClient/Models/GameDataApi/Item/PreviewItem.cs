using Newtonsoft.Json;

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
        [JsonProperty("item")]
        public Media Item { get; set; }

        /// <summary>
        /// Gets the quality of the item.
        /// </summary>
        [JsonProperty("quality")]
        public EnumType Quality { get; set; }

        /// <summary>
        /// Gets the name of the item.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

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
        /// Gets the binding type for the item.
        /// </summary>
        [JsonProperty("binding")]
        public EnumType Binding { get; set; }

        /// <summary>
        /// Gets an indication of whether the item is unique-equipped.
        /// </summary>
        [JsonProperty("unique_equipped")]
        public string UniqueEquipped { get; set; }

        /// <summary>
        /// Gets weapon information for the item.
        /// </summary>
        [JsonProperty("weapon")]
        public Weapon Weapon { get; set; }

        /// <summary>
        /// Gets the stats associated with the item.
        /// </summary>
        [JsonProperty("stats")]
        public Stat[] Stats { get; set; }

        /// <summary>
        /// Gets the spells associated with the item.
        /// </summary>
        [JsonProperty("spells")]
        public ItemSpell[] Spells { get; set; }

        /// <summary>
        /// Gets the sell price of the item.
        /// </summary>
        [JsonProperty("sell_price")]
        public SellPrice SellPrice { get; set; }

        /// <summary>
        /// Gets the level requiements for using an item.
        /// </summary>
        [JsonProperty("requirements")]
        public Requirements Requirements { get; set; }

        /// <summary>
        /// Gets the item level.
        /// </summary>
        [JsonProperty("level")]
        public DescribedValue Level { get; set; }

        /// <summary>
        /// Gets the durability of the item.
        /// </summary>
        [JsonProperty("durability")]
        public DescribedValue Durability { get; set; }
    }
}
