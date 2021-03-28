using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A PvP talent slot.
    /// </summary>
    public record TalentSlot
    {
        /// <summary>
        /// Gets the PvP talent slot number.
        /// </summary>
        [JsonPropertyName("slot_number")]
        public int SlotNumber { get; }

        /// <summary>
        /// Gets the player level required to unlock the PvP talent slot.
        /// </summary>
        [JsonPropertyName("unlock_player_level")]
        public int UnlockPlayerLevel { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TalentSlot"/> class.
        /// </summary>
        /// <param name="slotNumber">The PvP talent slot number.</param>
        /// <param name="unlockPlayerLevel">The player level required to unlock the PvP talent slot.</param>
        [JsonConstructor]
        public TalentSlot(int slotNumber, int unlockPlayerLevel)
        {
            SlotNumber = slotNumber;
            UnlockPlayerLevel = unlockPlayerLevel;
        }
    }
}
