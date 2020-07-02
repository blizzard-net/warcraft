using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A PvP talent belonging to a playable specialization.
    /// </summary>
    public class PvpTalentElement
    {
        /// <summary>
        /// Gets a reference to the PvP talent.
        /// </summary>
        [JsonProperty("talent")]
        public PvpTalentReference Talent { get; set; }

        /// <summary>
        /// Gets the spell tooltip for the PvP talent.
        /// </summary>
        [JsonProperty("spell_tooltip")]
        public SpellTooltip SpellTooltip { get; set; }
    }
}
