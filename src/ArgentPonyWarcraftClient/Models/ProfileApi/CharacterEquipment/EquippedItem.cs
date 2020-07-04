using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An equipped item.
    /// </summary>
    public class EquippedItem
    {
        /// <summary>
        /// Gets a reference to the item.
        /// </summary>
        [JsonProperty("item")]
        public ItemReferenceWithoutName Item { get; set; }

        /// <summary>
        /// Gets the slot in which the item is equipped.
        /// </summary>
        [JsonProperty("slot")]
        public EnumType Slot { get; set; }

        /// <summary>
        /// Gets the quantity of the item.
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// Gets the context of the item.
        /// </summary>
        [JsonProperty("context", NullValueHandling = NullValueHandling.Ignore)]
        public long? Context { get; set; }

        /// <summary>
        /// Gets the IDs of bonuses for the item.
        /// </summary>
        [JsonProperty("bonus_list", NullValueHandling = NullValueHandling.Ignore)]
        public long[] BonusList { get; set; }

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
        /// Gets the azerite details for the item.
        /// </summary>
        [JsonProperty("azerite_details", NullValueHandling = NullValueHandling.Ignore)]
        public AzeriteDetails AzeriteDetails { get; set; }

        /// <summary>
        /// Gets a reference to the item media.
        /// </summary>
        [JsonProperty("media")]
        public ItemMediaReference Media { get; set; }

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
        /// Gets the inventory type.
        /// </summary>
        [JsonProperty("inventory_type")]
        public EnumType InventoryType { get; set; }

        /// <summary>
        /// Gets the binding type.
        /// </summary>
        [JsonProperty("binding")]
        public EnumType Binding { get; set; }

        /// <summary>
        /// Gets the armor details for the item.
        /// </summary>
        [JsonProperty("armor", NullValueHandling = NullValueHandling.Ignore)]
        public Armor Armor { get; set; }

        /// <summary>
        /// Gets the statistics for the item.
        /// </summary>
        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public Stat[] Stats { get; set; }

        /// <summary>
        /// Gets the requirements for using the item.
        /// </summary>
        [JsonProperty("requirements", NullValueHandling = NullValueHandling.Ignore)]
        public Requirements Requirements { get; set; }

        /// <summary>
        /// Gets the item level.
        /// </summary>
        [JsonProperty("level")]
        public DescribedValue Level { get; set; }

        /// <summary>
        /// Gets the transmogrification details for the item.
        /// </summary>
        [JsonProperty("transmog", NullValueHandling = NullValueHandling.Ignore)]
        public Transmog Transmog { get; set; }

        /// <summary>
        /// Gets the durability of the item.
        /// </summary>
        [JsonProperty("durability", NullValueHandling = NullValueHandling.Ignore)]
        public DescribedValue Durability { get; set; }

        /// <summary>
        /// Gets a unique-equipped indication.
        /// </summary>
        [JsonProperty("unique_equipped", NullValueHandling = NullValueHandling.Ignore)]
        public string UniqueEquipped { get; set; }

        /// <summary>
        /// Gets the spell effects for the item.
        /// </summary>
        [JsonProperty("spells", NullValueHandling = NullValueHandling.Ignore)]
        public ItemSpell[] Spells { get; set; }

        /// <summary>
        /// Gets a description of the item.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets a value indicating whether the item subclass is hidden.
        /// </summary>
        [JsonProperty("is_subclass_hidden", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSubclassHidden { get; set; }

        /// <summary>
        /// Gets the sell price of the item.
        /// </summary>
        [JsonProperty("sell_price", NullValueHandling = NullValueHandling.Ignore)]
        public SellPrice SellPrice { get; set; }

        /// <summary>
        /// Gets a value indicating whether the item is corrupted.
        /// </summary>
        [JsonProperty("is_corrupted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCorrupted { get; set; }

        /// <summary>
        /// Gets a name description modifier for the item.
        /// </summary>
        [JsonProperty("name_description", NullValueHandling = NullValueHandling.Ignore)]
        public NameDescription NameDescription { get; set; }

        /// <summary>
        /// Gets the modified appearance ID for the item.
        /// </summary>
        [JsonProperty("modified_appearance_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? ModifiedAppearanceId { get; set; }

        /// <summary>
        /// Gets the item sockets.
        /// </summary>
        [JsonProperty("sockets", NullValueHandling = NullValueHandling.Ignore)]
        public Socket[] Sockets { get; set; }

        /// <summary>
        /// Gets weapon details for the item.
        /// </summary>
        [JsonProperty("weapon", NullValueHandling = NullValueHandling.Ignore)]
        public Weapon Weapon { get; set; }
    }
}
