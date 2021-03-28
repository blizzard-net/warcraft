using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Details about the appearance of an equipped item.
    /// </summary>
    public record EquippedItemAppearance
    {
        /// <summary>
        /// Gets the ID of the item.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the slot in which the item is equipped.
        /// </summary>
        [JsonPropertyName("slot")]
        public EnumType Slot { get; }

        /// <summary>
        /// Gets the ID of the enchantment that has been applied to the item or zero if it is not enchanted.
        /// </summary>
        [JsonPropertyName("enchant")]
        public int Enchant { get; }

        /// <summary>
        /// Gets the ID of the item appearance modifier.
        /// </summary>
        [JsonPropertyName("item_appearance_modifier_id")]
        public int ItemAppearanceModifierId { get; }

        /// <summary>
        /// Gets the internal slot ID.
        /// </summary>
        [JsonPropertyName("internal_slot_id")]
        public int InternalSlotId { get; }

        /// <summary>
        /// Gets the subclass of the item.
        /// </summary>
        [JsonPropertyName("subclass")]
        public int Subclass { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EquippedItemAppearance"/> class.
        /// </summary>
        /// <param name="id">The ID of the item.</param>
        /// <param name="slot">The slot in which the item is equipped.</param>
        /// <param name="enchant">The ID of the enchantment that has been applied to the item or zero if it is not enchanted.</param>
        /// <param name="itemAppearanceModifierId">The ID of the item appearance modifier.</param>
        /// <param name="internalSlotId">The internal slot ID.</param>
        /// <param name="subclass">The subclass of the item.</param>
        [JsonConstructor]
        public EquippedItemAppearance(int id, EnumType slot, int enchant, int itemAppearanceModifierId, int internalSlotId, int subclass)
        {
            Id = id;
            Slot = slot;
            Enchant = enchant;
            ItemAppearanceModifierId = itemAppearanceModifierId;
            InternalSlotId = internalSlotId;
            Subclass = subclass;
        }
    }
}
