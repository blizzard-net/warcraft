using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    public class TechTalentTree
    {
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("max_tiers")]
        public int MaxTiers { get; set; }

        [JsonPropertyName("talents")]
        public TechTalentReference[] Talents { get; set; }
    }
}
