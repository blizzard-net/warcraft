using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A PvP talent slot.
    /// </summary>
    public class TalentSlot
    {
        /// <summary>
        /// Gets the PvP talent slot number.
        /// </summary>
        [JsonProperty("slot_number")]
        public long SlotNumber { get; set; }

        /// <summary>
        /// Gets the player level required to unlock the PvP talent slot.
        /// </summary>
        [JsonProperty("unlock_player_level")]
        public long UnlockPlayerLevel { get; set; }
    }
}
