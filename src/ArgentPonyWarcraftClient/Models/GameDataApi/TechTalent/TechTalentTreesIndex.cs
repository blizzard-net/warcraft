using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    public class TechTalentTreesIndex
    {
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        [JsonPropertyName("talent_trees")]
        public TechTalentReference[] TalentTrees { get; set; }
    }
}
