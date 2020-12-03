using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A covenant.
    /// </summary>
    public class Covenant
    {
        /// <summary>
        /// Gets the key for this covenant.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the Id for this covenant.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets the name for this covenant.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the description for this covenant.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets the signature ability for this covenant.
        /// </summary>
        [JsonPropertyName("signature_ability")]
        public CovenantSignatureAbility SignatureAbility { get; set; }

        /// <summary>
        /// Gets the various class abilities for this covenant.
        /// </summary>
        [JsonPropertyName("class_abilities")]
        public CovenantClassAbility[] ClassAbilities { get; set; }
    }
}
