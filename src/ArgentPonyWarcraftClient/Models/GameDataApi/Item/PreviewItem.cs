namespace ArgentPonyWarcraftClient;

/// <summary>
/// Item preview data.
/// </summary>
public record PreviewItem
{
    /// <summary>
    /// Gets a reference to the item.
    /// </summary>
    [JsonPropertyName("item")]
    public Media Item { get; init; }

    /// <summary>
    /// Gets the context for the item.
    /// </summary>
    [JsonPropertyName("context")]
    public int Context { get; init; }

    /// <summary>
    /// Gets the bonus list for the item.
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
    /// Gets the media associated with this item.
    /// </summary>
    [JsonPropertyName("media")]
    public Media Media { get; init; }

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
    /// Gets the inventory type for the item.
    /// </summary>
    [JsonPropertyName("inventory_type")]
    public EnumType InventoryType { get; init; }

    /// <summary>
    /// Gets the binding type for the item.
    /// </summary>
    [JsonPropertyName("binding")]
    public EnumType Binding { get; init; }

    /// <summary>
    /// Gets an indication of whether the item is unique-equipped.
    /// </summary>
    [JsonPropertyName("unique_equipped")]
    public string UniqueEquipped { get; init; }

    /// <summary>
    /// Gets weapon information for the item.
    /// </summary>
    [JsonPropertyName("weapon")]
    public Weapon Weapon { get; init; }

    /// <summary>
    /// Gets the stats associated with the item.
    /// </summary>
    [JsonPropertyName("stats")]
    public Stat[] Stats { get; init; }

    /// <summary>
    /// Gets the spells associated with the item.
    /// </summary>
    [JsonPropertyName("spells")]
    public ItemSpell[] Spells { get; init; }

    /// <summary>
    /// Gets the sell price of the item.
    /// </summary>
    [JsonPropertyName("sell_price")]
    public SellPrice SellPrice { get; init; }

    /// <summary>
    /// Gets the level requiements for using an item.
    /// </summary>
    [JsonPropertyName("requirements")]
    public Requirements Requirements { get; init; }

    /// <summary>
    /// Gets the item level.
    /// </summary>
    [JsonPropertyName("level")]
    public DescribedValue Level { get; init; }

    /// <summary>
    /// Gets the durability of the item.
    /// </summary>
    [JsonPropertyName("durability")]
    public DescribedValue Durability { get; init; }
}
