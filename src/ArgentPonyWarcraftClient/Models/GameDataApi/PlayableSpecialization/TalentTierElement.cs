using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A talent belonging to a talent tier for a playable specialization.
    /// </summary>
    public record TalentTierElement
    {
        /// <summary>
        /// Gets a reference to the talent.
        /// </summary>
        [JsonPropertyName("talent")]
        public TalentReference Talent { get; }

        /// <summary>
        /// Gets the spell tooltip for the talent as it appears in the tier.
        /// </summary>
        [JsonPropertyName("spell_tooltip")]
        public SpellTooltip SpellTooltip { get; }

        /// <summary>
        /// Gets the column index at which the talent appears in the talent tier.
        /// </summary>
        [JsonPropertyName("column_index")]
        public int ColumnIndex { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TalentTierElement"/> class.
        /// </summary>
        /// <param name="talent">A reference to the talent.</param>
        /// <param name="spellTooltip">The spell tooltip for the talent as it appears in the tier.</param>
        /// <param name="columnIndex">The column index at which the talent appears in the talent tier.</param>
        [JsonConstructor]
        public TalentTierElement(TalentReference talent, SpellTooltip spellTooltip, int columnIndex)
        {
            Talent = talent;
            SpellTooltip = spellTooltip;
            ColumnIndex = columnIndex;
        }
    }
}
