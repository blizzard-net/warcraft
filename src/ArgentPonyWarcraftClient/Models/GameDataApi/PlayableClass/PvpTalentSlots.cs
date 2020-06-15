using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the talent slots.
        /// </summary>
        [JsonProperty("talent_slots")]
        public TalentSlot[] TalentSlots { get; set; }
    }
}
