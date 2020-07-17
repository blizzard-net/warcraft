using System.Text.Json.Serialization;

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
        [JsonPropertyName("slot")]
        public long Slot { get; set; }

        /// <summary>
        /// Gets the rank of the selected essence.
        /// </summary>
        [JsonPropertyName("rank")]
        public long Rank { get; set; }

        /// <summary>
        /// Gets the main spell tooltip.
        /// </summary>
        [JsonPropertyName("main_spell_tooltip")]
        public SpellTooltip MainSpellTooltip { get; set; }

        /// <summary>
        /// Gets the passive spell tooltip.
        /// </summary>
        [JsonPropertyName("passive_spell_tooltip")]
        public SpellTooltip PassiveSpellTooltip { get; set; }

        /// <summary>
        /// Gets a reference to the azerite essence.
        /// </summary>
        [JsonPropertyName("essence")]
        public AzeriteEssenceReference Essence { get; set; }

        /// <summary>
        /// Gets a reference to the azerite essence media.
        /// </summary>
        [JsonPropertyName("media")]
        public AzeritEssenceMediaReference Media { get; set; }
    }
}
