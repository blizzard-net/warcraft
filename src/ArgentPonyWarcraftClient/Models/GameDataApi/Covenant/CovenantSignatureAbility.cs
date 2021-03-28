using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A covenant signature ability.
    /// </summary>
    public record CovenantSignatureAbility
    {
        /// <summary>
        /// Gets the Id for the covenant's signature ability.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the spell tooltip for the signature ability.
        /// </summary>
        [JsonPropertyName("spell_tooltip")]
        public SpellTooltip SpellTooltip { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CovenantSignatureAbility"/> class.
        /// </summary>
        /// <param name="id">The Id for the covenant's signature ability.</param>
        /// <param name="spellTooltip">The spell tooltip for the signature ability.</param>
        [JsonConstructor]
        public CovenantSignatureAbility(int id, SpellTooltip spellTooltip)
        {
            Id = id;
            SpellTooltip = spellTooltip;
        }
    }
}
