namespace ArgentPonyWarcraftClient;

/// <summary>
/// An equipped item.
/// </summary>
public record EquippedItem
{
    /// <summary>
    /// Gets a reference to the item.
    /// </summary>
    [JsonPropertyName("item")]
    public ItemReferenceWithoutName Item { get; init; }

    /// <summary>
    /// Gets the slot in which the item is equipped.
    /// </summary>
    [JsonPropertyName("slot")]
    public EnumType Slot { get; init; }

    /// <summary>
    /// Gets the quantity of the item.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int Quantity { get; init; }

    /// <summary>
    /// Gets the context of the item.
    /// </summary>
    [JsonPropertyName("context")]
    public int? Context { get; init; }

    /// <summary>
    /// Gets the IDs of bonuses for the item.
    /// </summary>
    [JsonPropertyName("bonus_list")]
    public int[] BonusList { get; init; }

    /// <summary>
    /// Gets the quality of the item.
    /// </summary>
    [JsonPropertyName("quality")]
    public EnumType Quality { get; init; }

    /// <summary>
    /// Gets the name of the item.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the azerite details for the item.
    /// </summary>
    [JsonPropertyName("azerite_details")]
    public AzeriteDetails AzeriteDetails { get; init; }

    /// <summary>
    /// Gets a reference to the item media.
    /// </summary>
    [JsonPropertyName("media")]
    public ItemMediaReference Media { get; init; }

    /// <summary>
    /// Gets a reference to the item class.
    /// </summary>
    [JsonPropertyName("item_class")]
    public ItemClassReference ItemClass { get; init; }

    /// <summary>
    /// Gets a reference to the item subclass.
    /// </summary>
    [JsonPropertyName("item_subclass")]
    public ItemSubclassReference ItemSubclass { get; init; }

    /// <summary>
    /// Gets the inventory type.
    /// </summary>
    [JsonPropertyName("inventory_type")]
    public EnumType InventoryType { get; init; }

    /// <summary>
    /// Gets the binding type.
    /// </summary>
    [JsonPropertyName("binding")]
    public EnumType Binding { get; init; }

    /// <summary>
    /// Gets the armor details for the item.
    /// </summary>
    [JsonPropertyName("armor")]
    public Armor Armor { get; init; }

    /// <summary>
    /// Gets the statistics for the item.
    /// </summary>
    [JsonPropertyName("stats")]
    public Stat[] Stats { get; init; }

    /// <summary>
    /// Gets the requirements for using the item.
    /// </summary>
    [JsonPropertyName("requirements")]
    public Requirements Requirements { get; init; }

    /// <summary>
    /// Gets the item level.
    /// </summary>
    [JsonPropertyName("level")]
    public DescribedValue Level { get; init; }

    /// <summary>
    /// Gets the transmogrification details for the item.
    /// </summary>
    [JsonPropertyName("transmog")]
    public Transmog Transmog { get; init; }

    /// <summary>
    /// Gets the durability of the item.
    /// </summary>
    [JsonPropertyName("durability")]
    public DescribedValue Durability { get; init; }

    /// <summary>
    /// Gets a unique-equipped indication.
    /// </summary>
    [JsonPropertyName("unique_equipped")]
    public string UniqueEquipped { get; init; }

    /// <summary>
    /// Gets the spell effects for the item.
    /// </summary>
    [JsonPropertyName("spells")]
    public ItemSpell[] Spells { get; init; }

    /// <summary>
    /// Gets a description of the item.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; init; }

    /// <summary>
    /// Gets a value indicating whether the item subclass is hidden.
    /// </summary>
    [JsonPropertyName("is_subclass_hidden")]
    public bool? IsSubclassHidden { get; init; }

    /// <summary>
    /// Gets the sell price of the item.
    /// </summary>
    [JsonPropertyName("sell_price")]
    public SellPrice SellPrice { get; init; }

    /// <summary>
    /// Gets a value indicating whether the item is corrupted.
    /// </summary>
    [JsonPropertyName("is_corrupted")]
    public bool? IsCorrupted { get; init; }

    /// <summary>
    /// Gets a name description modifier for the item.
    /// </summary>
    [JsonPropertyName("name_description")]
    public NameDescription NameDescription { get; init; }

    /// <summary>
    /// Gets the modified appearance ID for the item.
    /// </summary>
    [JsonPropertyName("modified_appearance_id")]
    public int? ModifiedAppearanceId { get; init; }

    /// <summary>
    /// Gets the item sockets.
    /// </summary>
    [JsonPropertyName("sockets")]
    public Socket[] Sockets { get; init; }

    /// <summary>
    /// Gets the enchantment of the item.
    /// </summary>
    [JsonPropertyName("enchantments")]
    public Enchantment[] Enchantments { get; init; }

    /// <summary>
    /// Gets weapon details for the item.
    /// </summary>
    [JsonPropertyName("weapon")]
    public Weapon Weapon { get; init; }
}
