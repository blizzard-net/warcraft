using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    public class TechTalentMedia
    {
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        [JsonPropertyName("assets")]
        public Asset[] Assets { get; set; }
    }
}
