using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A covenant class ability.
    /// </summary>
    public record CovenantClassAbility
    {
        /// <summary>
        /// Gets the Id for this class ability.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets a reference to the playable class associated with this ability.
        /// </summary>
        [JsonPropertyName("playable_class")]
        public PlayableClassReference PlayableClass { get; }

        /// <summary>
        /// Gets the spell tooltip for this ability.
        /// </summary>
        [JsonPropertyName("spell_tooltip")]
        public SpellTooltip SpellTooltip { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CovenantClassAbility"/> class.
        /// </summary>
        /// <param name="id">The Id for this class ability.</param>
        /// <param name="playableClass">A reference to the playable class associated with this ability.</param>
        /// <param name="spellTooltip">The spell tooltip for this ability.</param>
        [JsonConstructor]
        public CovenantClassAbility(int id, PlayableClassReference playableClass, SpellTooltip spellTooltip)
        {
            Id = id;
            PlayableClass = playableClass;
            SpellTooltip = spellTooltip;
        }
    }
}
