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

        /// <summary>
        /// Gets the soulbind references for this covenant.
        /// </summary>
        [JsonPropertyName("soulbinds")]
        public SoulbindReference[] Soulbinds { get; set; }

        /// <summary>
        /// Gets the renown rewards for this covenant.
        /// </summary>
        [JsonPropertyName("renown_rewards")]
        public RenownReward[] RenownRewards { get; set; }

        /// <summary>
        /// Gets the media reference for this covenant.
        /// </summary>
        [JsonPropertyName("media")]
        public CovenantMediaReference Media { get; set; }
    }
}
