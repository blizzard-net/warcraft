using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    public class Covenant
    {
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("signature_ability")]
        public CovenantSignatureAbility SignatureAbility { get; set; }

        [JsonPropertyName("class_abilities")]
        public CovenantClassAbility ClassAbilities { get; set; }
    }
}
