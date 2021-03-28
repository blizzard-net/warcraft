using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A covenant class ability.
    /// </summary>
    public class CovenantClassAbility
    {
        /// <summary>
        /// Gets the Id for this class ability.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets a reference to the playable class associated with this ability.
        /// </summary>
        [JsonPropertyName("playable_class")]
        public PlayableClassReference PlayableClass { get; set; }

        /// <summary>
        /// Gets the spell tooltip for this ability.
        /// </summary>
        [JsonPropertyName("spell_tooltip")]
        public SpellTooltip SpellTooltip { get; set; }
    }
}
