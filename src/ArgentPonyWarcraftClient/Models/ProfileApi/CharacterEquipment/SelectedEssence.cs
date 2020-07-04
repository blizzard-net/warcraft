using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A selected azerite essence.
    /// </summary>
    public class SelectedEssence
    {
        /// <summary>
        /// Gets the slot of the selected essence.
        /// </summary>
        [JsonProperty("slot")]
        public long Slot { get; set; }

        /// <summary>
        /// Gets the rank of the selected essence.
        /// </summary>
        [JsonProperty("rank")]
        public long Rank { get; set; }

        /// <summary>
        /// Gets the main spell tooltip.
        /// </summary>
        [JsonProperty("main_spell_tooltip", NullValueHandling = NullValueHandling.Ignore)]
        public SpellTooltip MainSpellTooltip { get; set; }

        /// <summary>
        /// Gets the passive spell tooltip.
        /// </summary>
        [JsonProperty("passive_spell_tooltip")]
        public SpellTooltip PassiveSpellTooltip { get; set; }

        /// <summary>
        /// Gets a reference to the azerite essence.
        /// </summary>
        [JsonProperty("essence")]
        public AzeriteEssenceReference Essence { get; set; }

        /// <summary>
        /// Gets a reference to the azerite essence media.
        /// </summary>
        [JsonProperty("media")]
        public AzeritEssenceMediaReference Media { get; set; }
    }
}
