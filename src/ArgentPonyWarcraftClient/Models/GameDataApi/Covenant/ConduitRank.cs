using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A conduit rank.
    /// </summary>
    public record ConduitRank
    {
        /// <summary>
        /// Gets the Id of the conduit rank.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the tier of the conduit rank.
        /// </summary>
        [JsonPropertyName("tier")]
        public long Tier { get; }

        /// <summary>
        /// Gets the spell tooltip of the conduit rank.
        /// </summary>
        [JsonPropertyName("spell_tooltip")]
        public SpellTooltip SpellTooltip { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConduitRank"/> class.
        /// </summary>
        /// <param name="id">The Id of the conduit rank.</param>
        /// <param name="tier">The tier of the conduit rank.</param>
        /// <param name="spellTooltip">The spell tooltip of the conduit rank.</param>
        [JsonConstructor]
        public ConduitRank(int id, long tier, SpellTooltip spellTooltip)
        {
            Id = id;
            Tier = tier;
            SpellTooltip = spellTooltip;
        }
    }
}
