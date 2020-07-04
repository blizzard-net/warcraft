using Newtonsoft.Json;

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
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the tier for the azerite power.
        /// </summary>
        [JsonProperty("tier")]
        public long Tier { get; set; }

        /// <summary>
        /// Gets the spell tooltip for the azerite power.
        /// </summary>
        [JsonProperty("spell_tooltip")]
        public SpellTooltip SpellTooltip { get; set; }

        /// <summary>
        /// Gets a value indicating whether the display is hidden.
        /// </summary>
        [JsonProperty("is_display_hidden", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDisplayHidden { get; set; }
    }
}
