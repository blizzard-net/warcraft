using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A conduit rank.
    /// </summary>
    public class ConduitRank
    {
        /// <summary>
        /// Gets the Id of the conduit rank.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets the tier of the conduit rank.
        /// </summary>
        [JsonPropertyName("tier")]
        public int Tier { get; set; }

        /// <summary>
        /// Gets the spell tooltip of the conduit rank.
        /// </summary>
        [JsonPropertyName("spell_tooltip")]
        public SpellTooltip SpellTooltip { get; set; }
    }
}
