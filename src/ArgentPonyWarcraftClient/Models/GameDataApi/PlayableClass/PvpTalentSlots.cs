using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// PvP talent slots for a playable class.
    /// </summary>
    public record PvpTalentSlots
    {
        /// <summary>
        /// Gets links for the PvP talent slots.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the talent slots.
        /// </summary>
        [JsonPropertyName("talent_slots")]
        public TalentSlot[] TalentSlots { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PvpTalentSlots"/> class.
        /// </summary>
        /// <param name="links">Links for the PvP talent slots.</param>
        /// <param name="talentSlots">The talent slots.</param>
        [JsonConstructor]
        public PvpTalentSlots(Links links, TalentSlot[] talentSlots)
        {
            Links = links;
            TalentSlots = talentSlots;
        }
    }
}
