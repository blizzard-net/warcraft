using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    public class TechTalentsIndex
    {
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        [JsonPropertyName("talents")]
        public TechTalentReference[] Talents { get; set; }
    }
}
