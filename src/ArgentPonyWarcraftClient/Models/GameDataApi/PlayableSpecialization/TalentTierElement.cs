using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A talent belonging to a talent tier for a playable specialization.
    /// </summary>
    public class TalentTierElement
    {
        /// <summary>
        /// Gets a reference to the talent.
        /// </summary>
        [JsonProperty("talent")]
        public TalentReference Talent { get; set; }

        /// <summary>
        /// Gets the spell tooltip for the talent as it appears in the tier.
        /// </summary>
        [JsonProperty("spell_tooltip")]
        public SpellTooltip SpellTooltip { get; set; }

        /// <summary>
        /// Gets the column index at which the talent appears in the talent tier.
        /// </summary>
        [JsonProperty("column_index")]
        public long ColumnIndex { get; set; }
    }
}
