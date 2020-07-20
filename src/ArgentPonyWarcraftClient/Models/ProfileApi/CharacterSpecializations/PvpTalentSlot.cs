using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A PvP talent slot.
    /// </summary>
    public class PvpTalentSlot
    {
        /// <summary>
        /// Gets the selected PvP talent.
        /// </summary>
        [JsonPropertyName("selected")]
        public PvpTalentElementForAbility Selected { get; set; }

        /// <summary>
        /// Gets the PvP talent slot number.
        /// </summary>
        [JsonPropertyName("slot_number")]
        public long SlotNumber { get; set; }
    }
}
