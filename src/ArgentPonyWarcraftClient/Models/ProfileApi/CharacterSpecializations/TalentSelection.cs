using Newtonsoft.Json;

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
        [JsonProperty("talent")]
        public TalentReference Talent { get; set; }

        /// <summary>
        /// Gets the spell tooltip for the talent.
        /// </summary>
        [JsonProperty("spell_tooltip")]
        public SpellTooltipForAbility SpellTooltip { get; set; }

        /// <summary>
        /// Gets the tier index for the talent.
        /// </summary>
        [JsonProperty("tier_index")]
        public long TierIndex { get; set; }

        /// <summary>
        /// Gets the column index for the talent.
        /// </summary>
        [JsonProperty("column_index")]
        public long ColumnIndex { get; set; }
    }
}
