using System.Text.Json.Serialization;

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
        [JsonPropertyName("slot_number")]
        public long SlotNumber { get; set; }

        /// <summary>
        /// Gets the player level required to unlock the PvP talent slot.
        /// </summary>
        [JsonPropertyName("unlock_player_level")]
        public long UnlockPlayerLevel { get; set; }
    }
}
