using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Item preview data.
    /// </summary>
    public record PreviewItem
    {
        /// <summary>
        /// Gets a reference to the item.
        /// </summary>
        [JsonPropertyName("item")]
        public Media Item { get; }

        /// <summary>
        /// Gets the quality of the item.
        /// </summary>
        [JsonPropertyName("quality")]
        public EnumType Quality { get; }

        /// <summary>
        /// Gets the name of the item.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

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
        /// Gets the binding type for the item.
        /// </summary>
        [JsonPropertyName("binding")]
        public EnumType Binding { get; }

        /// <summary>
        /// Gets an indication of whether the item is unique-equipped.
        /// </summary>
        [JsonPropertyName("unique_equipped")]
        public string UniqueEquipped { get; }

        /// <summary>
        /// Gets weapon information for the item.
        /// </summary>
        [JsonPropertyName("weapon")]
        public Weapon Weapon { get; }

        /// <summary>
        /// Gets the stats associated with the item.
        /// </summary>
        [JsonPropertyName("stats")]
        public Stat[] Stats { get; }

        /// <summary>
        /// Gets the spells associated with the item.
        /// </summary>
        [JsonPropertyName("spells")]
        public ItemSpell[] Spells { get; }

        /// <summary>
        /// Gets the sell price of the item.
        /// </summary>
        [JsonPropertyName("sell_price")]
        public SellPrice SellPrice { get; }

        /// <summary>
        /// Gets the level requiements for using an item.
        /// </summary>
        [JsonPropertyName("requirements")]
        public Requirements Requirements { get; }

        /// <summary>
        /// Gets the item level.
        /// </summary>
        [JsonPropertyName("level")]
        public DescribedValue Level { get; }

        /// <summary>
        /// Gets the durability of the item.
        /// </summary>
        [JsonPropertyName("durability")]
        public DescribedValue Durability { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewItem"/> class.
        /// </summary>
        /// <param name="item">A reference to the item.</param>
        /// <param name="quality">The quality of the item.</param>
        /// <param name="name">The name of the item.</param>
        /// <param name="media">The media associated with this item.</param>
        /// <param name="itemClass">A reference to the item class.</param>
        /// <param name="itemSubclass">A reference to the item subclass.</param>
        /// <param name="inventoryType">The inventory type for the item.</param>
        /// <param name="binding">The binding type for the item.</param>
        /// <param name="uniqueEquipped">An indication of whether the item is unique-equipped.</param>
        /// <param name="weapon">Weapon information for the item.</param>
        /// <param name="stats">The stats associated with the item.</param>
        /// <param name="spells">The spells associated with the item.</param>
        /// <param name="sellPrice">The sell price of the item.</param>
        /// <param name="requirements">The level requiements for using an item.</param>
        /// <param name="level">The item level.</param>
        /// <param name="durability">The durability of the item.</param>
        [JsonConstructor]
        public PreviewItem(Media item, EnumType quality, string name, Media media, ItemClassReference itemClass, ItemSubclassReference itemSubclass, EnumType inventoryType, EnumType binding, string uniqueEquipped, Weapon weapon, Stat[] stats, ItemSpell[] spells, SellPrice sellPrice, Requirements requirements, DescribedValue level, DescribedValue durability)
        {
            Item = item;
            Quality = quality;
            Name = name;
            Media = media;
            ItemClass = itemClass;
            ItemSubclass = itemSubclass;
            InventoryType = inventoryType;
            Binding = binding;
            UniqueEquipped = uniqueEquipped;
            Weapon = weapon;
            Stats = stats;
            Spells = spells;
            SellPrice = sellPrice;
            Requirements = requirements;
            Level = level;
            Durability = durability;
        }
    }
}
