using System;
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

    /// <summary>
    /// Level requirements for an item.
    /// </summary>
    public class Requirements
    {
        /// <summary>
        /// Gets the required level for using an item.
        /// </summary>
        [JsonProperty("level")]
        public DescribedValue Level { get; set; }
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(long) || t == typeof(long?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            string value = serializer.Deserialize<string>(reader);

            if (long.TryParse(value, out long l))
            {
                return l;
            }

            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            serializer.Serialize(writer, ((long)untypedValue).ToString());
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}
