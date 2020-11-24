using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    public class CovenantClassAbility
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("playable_class")]
        public PlayableClassReference PlayableClass { get; set; }

        [JsonPropertyName("spell_tooltip")]
        public SpellTooltip SpellTooltip { get; set; }
    }
}
