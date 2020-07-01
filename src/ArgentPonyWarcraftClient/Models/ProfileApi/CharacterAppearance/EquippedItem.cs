using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An equipped item.
    /// </summary>
    public class EquippedItem
    {
        /// <summary>
        /// Gets the ID of the item.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the slot in which the item is equipped.
        /// </summary>
        [JsonProperty("slot")]
        public EnumType Slot { get; set; }

        /// <summary>
        /// Gets the ID of the enchantment that has been applied to the item or zero if it is not enchanted.
        /// </summary>
        [JsonProperty("enchant")]
        public long Enchant { get; set; }

        /// <summary>
        /// Gets the ID of the item appearance modifier.
        /// </summary>
        [JsonProperty("item_appearance_modifier_id")]
        public long ItemAppearanceModifierId { get; set; }

        /// <summary>
        /// Gets the internal slot ID.
        /// </summary>
        [JsonProperty("internal_slot_id")]
        public long InternalSlotId { get; set; }

        /// <summary>
        /// Gets the subclass of the item.
        /// </summary>
        [JsonProperty("subclass")]
        public long Subclass { get; set; }
    }
}
