using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary> 
    /// A talent selection for a character's specialization.
    /// </summary>
    public record TalentSelection
    {
        /// <summary>
        /// Gets a reference to the talent.
        /// </summary>
        [JsonPropertyName("talent")]
        public TalentReference Talent { get; }

        /// <summary>
        /// Gets the spell tooltip for the talent.
        /// </summary>
        [JsonPropertyName("spell_tooltip")]
        public SpellTooltipForAbility SpellTooltip { get; }

        /// <summary>
        /// Gets the tier index for the talent.
        /// </summary>
        [JsonPropertyName("tier_index")]
        public int TierIndex { get; }

        /// <summary>
        /// Gets the column index for the talent.
        /// </summary>
        [JsonPropertyName("column_index")]
        public int ColumnIndex { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TalentSelection"/> class.
        /// </summary>
        /// <param name="talent">A reference to the talent.</param>
        /// <param name="spellTooltip">The spell tooltip for the talent.</param>
        /// <param name="tierIndex">The tier index for the talent.</param>
        /// <param name="columnIndex">The column index for the talent.</param>
        [JsonConstructor]
        public TalentSelection(TalentReference talent, SpellTooltipForAbility spellTooltip, int tierIndex, int columnIndex)
        {
            Talent = talent;
            SpellTooltip = spellTooltip;
            TierIndex = tierIndex;
            ColumnIndex = columnIndex;
        }
    }
}
