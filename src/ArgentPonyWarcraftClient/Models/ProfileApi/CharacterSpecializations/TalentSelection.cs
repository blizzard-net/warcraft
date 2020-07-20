using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary> 
    /// A talent selection for a character's specialization.
    /// </summary>
    public class TalentSelection
    {
        /// <summary>
        /// Gets a reference to the talent.
        /// </summary>
        [JsonPropertyName("talent")]
        public TalentReference Talent { get; set; }

        /// <summary>
        /// Gets the spell tooltip for the talent.
        /// </summary>
        [JsonPropertyName("spell_tooltip")]
        public SpellTooltipForAbility SpellTooltip { get; set; }

        /// <summary>
        /// Gets the tier index for the talent.
        /// </summary>
        [JsonPropertyName("tier_index")]
        public long TierIndex { get; set; }

        /// <summary>
        /// Gets the column index for the talent.
        /// </summary>
        [JsonPropertyName("column_index")]
        public long ColumnIndex { get; set; }
    }
}
