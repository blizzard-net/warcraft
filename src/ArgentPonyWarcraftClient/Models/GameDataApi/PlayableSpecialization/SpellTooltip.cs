using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A spell tooltip.
    /// </summary>
    public class SpellTooltip
    {
        /// <summary>
        /// Gets a reference to the spell.
        /// </summary>
        [JsonPropertyName("spell")]
        public SpellReference Spell { get; set; }

        /// <summary>
        /// Gets the description of the spell.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets the cast time of the spell.
        /// </summary>
        [JsonPropertyName("cast_time")]
        public string CastTime { get; set; }

        /// <summary>
        /// Gets the range of the spell.
        /// </summary>
        [JsonPropertyName("range")]
        public string Range { get; set; }

        /// <summary>
        /// Gets the cooldown of the spell.
        /// </summary>
        [JsonPropertyName("cooldown")]
        public string Cooldown { get; set; }

        /// <summary>
        /// Gets the power cost of the spell.
        /// </summary>
        [JsonPropertyName("power_cost")]
        public string PowerCost { get; set; }
    }
}
