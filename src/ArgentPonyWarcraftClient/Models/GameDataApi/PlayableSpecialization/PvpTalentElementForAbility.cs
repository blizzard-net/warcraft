using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A PvP talent selected by a character.
    /// </summary>
    public record PvpTalentElementForAbility
    {
        /// <summary>
        /// Gets a reference to the PvP talent.
        /// </summary>
        [JsonPropertyName("talent")]
        public PvpTalentReference Talent { get; }

        /// <summary>
        /// Gets the spell tooltip for the PvP talent.
        /// </summary>
        [JsonPropertyName("spell_tooltip")]
        public SpellTooltipForAbility SpellTooltip { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PvpTalentElementForAbility"/> class.
        /// </summary>
        /// <param name="talent">A reference to the PvP talent.</param>
        /// <param name="spellTooltip">The spell tooltip for the PvP talent.</param>
        [JsonConstructor]
        public PvpTalentElementForAbility(PvpTalentReference talent, SpellTooltipForAbility spellTooltip)
        {
            Talent = talent;
            SpellTooltip = spellTooltip;
        }
    }
}
