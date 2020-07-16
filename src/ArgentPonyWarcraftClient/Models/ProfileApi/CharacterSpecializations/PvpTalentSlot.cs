using Newtonsoft.Json;

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
        [JsonProperty("selected")]
        public PvpTalentElementForAbility Selected { get; set; }

        /// <summary>
        /// Gets the PvP talent slot number.
        /// </summary>
        [JsonProperty("slot_number")]
        public long SlotNumber { get; set; }
    }
}
