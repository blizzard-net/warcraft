using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// PvP talent slots for a playable class.
    /// </summary>
    public class PvpTalentSlots
    {
        /// <summary>
        /// Gets links for the PvP talent slots.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the talent slots.
        /// </summary>
        [JsonPropertyName("talent_slots")]
        public TalentSlot[] TalentSlots { get; set; }
    }
}
