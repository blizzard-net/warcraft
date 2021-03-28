using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A PvP talent slot.
    /// </summary>
    public record PvpTalentSlot
    {
        /// <summary>
        /// Gets the selected PvP talent.
        /// </summary>
        [JsonPropertyName("selected")]
        public PvpTalentElementForAbility Selected { get; }

        /// <summary>
        /// Gets the PvP talent slot number.
        /// </summary>
        [JsonPropertyName("slot_number")]
        public int SlotNumber { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PvpTalentSlot"/> class.
        /// </summary>
        /// <param name="selected">The selected PvP talent.</param>
        /// <param name="slotNumber">The PvP talent slot number.</param>
        [JsonConstructor]
        public PvpTalentSlot(PvpTalentElementForAbility selected, int slotNumber)
        {
            Selected = selected;
            SlotNumber = slotNumber;
        }
    }
}
