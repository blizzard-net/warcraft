using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A PvP talent belonging to a playable specialization.
    /// </summary>
    public record PvpTalentElement
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
        public SpellTooltip SpellTooltip { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PvpTalentElement"/> class.
        /// </summary>
        /// <param name="talent">A reference to the PvP talent.</param>
        /// <param name="spellTooltip">The spell tooltip for the PvP talent.</param>
        [JsonConstructor]
        public PvpTalentElement(PvpTalentReference talent, SpellTooltip spellTooltip)
        {
            Talent = talent;
            SpellTooltip = spellTooltip;
        }
    }
}
