using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    public class TechTalent
    {
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("talent_tree")]
        public TechTalentTreeReference TalentTree { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("tier")]
        public int Tier { get; set; }

        [JsonPropertyName("display_order")]
        public int DisplayOrder { get; set; }

        [JsonPropertyName("media")]
        public Media Media { get; set; }
    }
}
