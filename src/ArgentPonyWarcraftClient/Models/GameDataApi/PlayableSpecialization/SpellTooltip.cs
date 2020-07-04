using Newtonsoft.Json;

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
        [JsonProperty("spell", NullValueHandling = NullValueHandling.Ignore)]
        public SpellReference Spell { get; set; }

        /// <summary>
        /// Gets the description of the spell.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets the cast time of the spell.
        /// </summary>
        [JsonProperty("cast_time")]
        public string CastTime { get; set; }

        /// <summary>
        /// Gets the range of the spell.
        /// </summary>
        [JsonProperty("range", NullValueHandling = NullValueHandling.Ignore)]
        public string Range { get; set; }

        /// <summary>
        /// Gets the cooldown of the spell.
        /// </summary>
        [JsonProperty("cooldown", NullValueHandling = NullValueHandling.Ignore)]
        public string Cooldown { get; set; }

        /// <summary>
        /// Gets the power cost of the spell.
        /// </summary>
        [JsonProperty("power_cost", NullValueHandling = NullValueHandling.Ignore)]
        public string PowerCost { get; set; }
    }
}
