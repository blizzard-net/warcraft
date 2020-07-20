using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A selected azerite power.
    /// </summary>
    public class SelectedPower
    {
        /// <summary>
        /// Gets the ID of the azerite power.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the tier for the azerite power.
        /// </summary>
        [JsonPropertyName("tier")]
        public long Tier { get; set; }

        /// <summary>
        /// Gets the spell tooltip for the azerite power.
        /// </summary>
        [JsonPropertyName("spell_tooltip")]
        public SpellTooltip SpellTooltip { get; set; }

        /// <summary>
        /// Gets a value indicating whether the display is hidden.
        /// </summary>
        [JsonPropertyName("is_display_hidden")]
        public bool? IsDisplayHidden { get; set; }
    }
}
