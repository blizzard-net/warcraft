using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Details about the appearance of an equipped item.
    /// </summary>
    public class EquippedItemAppearance
    {
        /// <summary>
        /// Gets the ID of the item.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the slot in which the item is equipped.
        /// </summary>
        [JsonPropertyName("slot")]
        public EnumType Slot { get; set; }

        /// <summary>
        /// Gets the ID of the enchantment that has been applied to the item or zero if it is not enchanted.
        /// </summary>
        [JsonPropertyName("enchant")]
        public long Enchant { get; set; }

        /// <summary>
        /// Gets the ID of the item appearance modifier.
        /// </summary>
        [JsonPropertyName("item_appearance_modifier_id")]
        public long ItemAppearanceModifierId { get; set; }

        /// <summary>
        /// Gets the internal slot ID.
        /// </summary>
        [JsonPropertyName("internal_slot_id")]
        public long InternalSlotId { get; set; }

        /// <summary>
        /// Gets the subclass of the item.
        /// </summary>
        [JsonPropertyName("subclass")]
        public long Subclass { get; set; }
    }
}
