using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A spell tooltip.
    /// </summary>
    public record SpellTooltipForAbility
    {
        /// <summary>
        /// Gets a reference to the spell.
        /// </summary>
        [JsonPropertyName("spell")]
        public SpellReference Spell { get; }

        /// <summary>
        /// Gets the description of the spell.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; }

        /// <summary>
        /// Gets the cast time of the spell.
        /// </summary>
        [JsonPropertyName("cast_time")]
        public string CastTime { get; }

        /// <summary>
        /// Gets the cooldown of the spell.
        /// </summary>
        [JsonPropertyName("cooldown")]
        public string Cooldown { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpellTooltipForAbility"/> class.
        /// </summary>
        /// <param name="spell">A reference to the spell.</param>
        /// <param name="description">The description of the spell.</param>
        /// <param name="castTime">The cast time of the spell.</param>
        /// <param name="cooldown">The cooldown of the spell.</param>
        [JsonConstructor]
        public SpellTooltipForAbility(SpellReference spell, string description, string castTime, string cooldown)
        {
            Spell = spell;
            Description = description;
            CastTime = castTime;
            Cooldown = cooldown;
        }
    }
}
