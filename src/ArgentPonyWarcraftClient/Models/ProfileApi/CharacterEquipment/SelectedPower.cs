using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A selected azerite power.
    /// </summary>
    public record SelectedPower
    {
        /// <summary>
        /// Gets the ID of the azerite power.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the tier for the azerite power.
        /// </summary>
        [JsonPropertyName("tier")]
        public int Tier { get; }

        /// <summary>
        /// Gets the spell tooltip for the azerite power.
        /// </summary>
        [JsonPropertyName("spell_tooltip")]
        public SpellTooltip SpellTooltip { get; }

        /// <summary>
        /// Gets a value indicating whether the display is hidden.
        /// </summary>
        [JsonPropertyName("is_display_hidden")]
        public bool? IsDisplayHidden { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectedPower"/> class.
        /// </summary>
        /// <param name="id">The ID of the azerite power.</param>
        /// <param name="tier">The tier for the azerite power.</param>
        /// <param name="spellTooltip">The spell tooltip for the azerite power.</param>
        /// <param name="isDisplayHidden">A value indicating whether the display is hidden.</param>
        [JsonConstructor]
        public SelectedPower(int id, int tier, SpellTooltip spellTooltip, bool? isDisplayHidden)
        {
            Id = id;
            Tier = tier;
            SpellTooltip = spellTooltip;
            IsDisplayHidden = isDisplayHidden;
        }
    }
}
