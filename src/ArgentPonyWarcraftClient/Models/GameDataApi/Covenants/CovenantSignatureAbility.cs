using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    public class CovenantSignatureAbility
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("spell_tooltip")]
        public SpellTooltip SpellTooltip { get; set; }
    }
}
