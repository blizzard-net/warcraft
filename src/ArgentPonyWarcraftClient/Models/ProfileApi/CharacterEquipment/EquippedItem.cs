using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An equipped item.
    /// </summary>
    public record EquippedItem
    {
        /// <summary>
        /// Gets a reference to the item.
        /// </summary>
        [JsonPropertyName("item")]
        public ItemReferenceWithoutName Item { get; }

        /// <summary>
        /// Gets the slot in which the item is equipped.
        /// </summary>
        [JsonPropertyName("slot")]
        public EnumType Slot { get; }

        /// <summary>
        /// Gets the quantity of the item.
        /// </summary>
        [JsonPropertyName("quantity")]
        public int Quantity { get; }

        /// <summary>
        /// Gets the context of the item.
        /// </summary>
        [JsonPropertyName("context")]
        public int? Context { get; }

        /// <summary>
        /// Gets the IDs of bonuses for the item.
        /// </summary>
        [JsonPropertyName("bonus_list")]
        public int[] BonusList { get; }

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
        /// Gets the azerite details for the item.
        /// </summary>
        [JsonPropertyName("azerite_details")]
        public AzeriteDetails AzeriteDetails { get; }

        /// <summary>
        /// Gets a reference to the item media.
        /// </summary>
        [JsonPropertyName("media")]
        public ItemMediaReference Media { get; }

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
        /// Gets the inventory type.
        /// </summary>
        [JsonPropertyName("inventory_type")]
        public EnumType InventoryType { get; }

        /// <summary>
        /// Gets the binding type.
        /// </summary>
        [JsonPropertyName("binding")]
        public EnumType Binding { get; }

        /// <summary>
        /// Gets the armor details for the item.
        /// </summary>
        [JsonPropertyName("armor")]
        public Armor Armor { get; }

        /// <summary>
        /// Gets the statistics for the item.
        /// </summary>
        [JsonPropertyName("stats")]
        public Stat[] Stats { get; }

        /// <summary>
        /// Gets the requirements for using the item.
        /// </summary>
        [JsonPropertyName("requirements")]
        public Requirements Requirements { get; }

        /// <summary>
        /// Gets the item level.
        /// </summary>
        [JsonPropertyName("level")]
        public DescribedValue Level { get; }

        /// <summary>
        /// Gets the transmogrification details for the item.
        /// </summary>
        [JsonPropertyName("transmog")]
        public Transmog Transmog { get; }

        /// <summary>
        /// Gets the durability of the item.
        /// </summary>
        [JsonPropertyName("durability")]
        public DescribedValue Durability { get; }

        /// <summary>
        /// Gets a unique-equipped indication.
        /// </summary>
        [JsonPropertyName("unique_equipped")]
        public string UniqueEquipped { get; }

        /// <summary>
        /// Gets the spell effects for the item.
        /// </summary>
        [JsonPropertyName("spells")]
        public ItemSpell[] Spells { get; }

        /// <summary>
        /// Gets a description of the item.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; }

        /// <summary>
        /// Gets a value indicating whether the item subclass is hidden.
        /// </summary>
        [JsonPropertyName("is_subclass_hidden")]
        public bool? IsSubclassHidden { get; }

        /// <summary>
        /// Gets the sell price of the item.
        /// </summary>
        [JsonPropertyName("sell_price")]
        public SellPrice SellPrice { get; }

        /// <summary>
        /// Gets a value indicating whether the item is corrupted.
        /// </summary>
        [JsonPropertyName("is_corrupted")]
        public bool? IsCorrupted { get; }

        /// <summary>
        /// Gets a name description modifier for the item.
        /// </summary>
        [JsonPropertyName("name_description")]
        public NameDescription NameDescription { get; }

        /// <summary>
        /// Gets the modified appearance ID for the item.
        /// </summary>
        [JsonPropertyName("modified_appearance_id")]
        public int? ModifiedAppearanceId { get; }

        /// <summary>
        /// Gets the item sockets.
        /// </summary>
        [JsonPropertyName("sockets")]
        public Socket[] Sockets { get; }

        /// <summary>
        /// Gets the enchantment of the item.
        /// </summary>
        [JsonPropertyName("enchantments")]
        public Enchantment[] Enchantments { get; }

        /// <summary>
        /// Gets weapon details for the item.
        /// </summary>
        [JsonPropertyName("weapon")]
        public Weapon Weapon { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EquippedItem"/> class.
        /// </summary>
        /// <param name="item">A reference to the item.</param>
        /// <param name="slot">The slot in which the item is equipped.</param>
        /// <param name="quantity">The quantity of the item.</param>
        /// <param name="context">The context of the item.</param>
        /// <param name="bonusList">The IDs of bonuses for the item.</param>
        /// <param name="quality">The quality of the item.</param>
        /// <param name="name">The name of the item.</param>
        /// <param name="azeriteDetails">The azerite details for the item.</param>
        /// <param name="media">A reference to the item media.</param>
        /// <param name="itemClass">A reference to the item class.</param>
        /// <param name="itemSubclass">A reference to the item subclass.</param>
        /// <param name="inventoryType">The inventory type.</param>
        /// <param name="binding">The binding type.</param>
        /// <param name="armor">The armor details for the item.</param>
        /// <param name="stats">The statistics for the item.</param>
        /// <param name="requirements">The requirements for using the item.</param>
        /// <param name="level">The item level.</param>
        /// <param name="transmog">The transmogrification details for the item.</param>
        /// <param name="durability">The durability of the item.</param>
        /// <param name="uniqueEquipped">A unique-equipped indication.</param>
        /// <param name="spells">The spell effects for the item.</param>
        /// <param name="description">A description of the item.</param>
        /// <param name="isSubclassHidden">A value indicating whether the item subclass is hidden.</param>
        /// <param name="sellPrice">The sell price of the item.</param>
        /// <param name="isCorrupted">A value indicating whether the item is corrupted.</param>
        /// <param name="nameDescription">A name description modifier for the item.</param>
        /// <param name="modifiedAppearanceId">The modified appearance ID for the item.</param>
        /// <param name="sockets">The item sockets.</param>
        /// <param name="enchantments">The enchantment of the item.</param>
        /// <param name="weapon">Weapon details for the item.</param>
        [JsonConstructor]
        public EquippedItem(ItemReferenceWithoutName item, EnumType slot, int quantity, int? context, int[] bonusList, EnumType quality, string name, AzeriteDetails azeriteDetails, ItemMediaReference media, ItemClassReference itemClass, ItemSubclassReference itemSubclass, EnumType inventoryType, EnumType binding, Armor armor, Stat[] stats, Requirements requirements, DescribedValue level, Transmog transmog, DescribedValue durability, string uniqueEquipped, ItemSpell[] spells, string description, bool? isSubclassHidden, SellPrice sellPrice, bool? isCorrupted, NameDescription nameDescription, int? modifiedAppearanceId, Socket[] sockets, Enchantment[] enchantments, Weapon weapon)
        {
            Item = item;
            Slot = slot;
            Quantity = quantity;
            Context = context;
            BonusList = bonusList;
            Quality = quality;
            Name = name;
            AzeriteDetails = azeriteDetails;
            Media = media;
            ItemClass = itemClass;
            ItemSubclass = itemSubclass;
            InventoryType = inventoryType;
            Binding = binding;
            Armor = armor;
            Stats = stats;
            Requirements = requirements;
            Level = level;
            Transmog = transmog;
            Durability = durability;
            UniqueEquipped = uniqueEquipped;
            Spells = spells;
            Description = description;
            IsSubclassHidden = isSubclassHidden;
            SellPrice = sellPrice;
            IsCorrupted = isCorrupted;
            NameDescription = nameDescription;
            ModifiedAppearanceId = modifiedAppearanceId;
            Sockets = sockets;
            Enchantments = enchantments;
            Weapon = weapon;
        }
    }
}
