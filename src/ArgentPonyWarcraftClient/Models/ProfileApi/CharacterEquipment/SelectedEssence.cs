using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A selected azerite essence.
    /// </summary>
    public record SelectedEssence
    {
        /// <summary>
        /// Gets the slot of the selected essence.
        /// </summary>
        [JsonPropertyName("slot")]
        public int Slot { get; }

        /// <summary>
        /// Gets the rank of the selected essence.
        /// </summary>
        [JsonPropertyName("rank")]
        public int Rank { get; }

        /// <summary>
        /// Gets the main spell tooltip.
        /// </summary>
        [JsonPropertyName("main_spell_tooltip")]
        public SpellTooltip MainSpellTooltip { get; }

        /// <summary>
        /// Gets the passive spell tooltip.
        /// </summary>
        [JsonPropertyName("passive_spell_tooltip")]
        public SpellTooltip PassiveSpellTooltip { get; }

        /// <summary>
        /// Gets a reference to the azerite essence.
        /// </summary>
        [JsonPropertyName("essence")]
        public AzeriteEssenceReference Essence { get; }

        /// <summary>
        /// Gets a reference to the azerite essence media.
        /// </summary>
        [JsonPropertyName("media")]
        public AzeritEssenceMediaReference Media { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectedEssence"/> class.
        /// </summary>
        /// <param name="slot">The slot of the selected essence.</param>
        /// <param name="rank">The rank of the selected essence.</param>
        /// <param name="mainSpellTooltip">The main spell tooltip.</param>
        /// <param name="passiveSpellTooltip">The passive spell tooltip.</param>
        /// <param name="essence">A reference to the azerite essence.</param>
        /// <param name="media">A reference to the azerite essence media.</param>
        [JsonConstructor]
        public SelectedEssence(int slot, int rank, SpellTooltip mainSpellTooltip, SpellTooltip passiveSpellTooltip, AzeriteEssenceReference essence, AzeritEssenceMediaReference media)
        {
            Slot = slot;
            Rank = rank;
            MainSpellTooltip = mainSpellTooltip;
            PassiveSpellTooltip = passiveSpellTooltip;
            Essence = essence;
            Media = media;
        }
    }
}
