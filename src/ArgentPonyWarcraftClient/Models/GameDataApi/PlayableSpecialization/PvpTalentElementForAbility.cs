using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A PvP talent selected by a character.
    /// </summary>
    public class PvpTalentElementForAbility
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
        public SpellTooltipForAbility SpellTooltip { get; set; }
    }
}
