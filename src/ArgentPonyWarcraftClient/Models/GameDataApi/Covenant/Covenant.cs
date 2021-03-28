using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A covenant.
    /// </summary>
    public record Covenant
    {
        /// <summary>
        /// Gets the key for this covenant.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the Id for this covenant.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name for this covenant.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the description for this covenant.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; }

        /// <summary>
        /// Gets the signature ability for this covenant.
        /// </summary>
        [JsonPropertyName("signature_ability")]
        public CovenantSignatureAbility SignatureAbility { get; }

        /// <summary>
        /// Gets the various class abilities for this covenant.
        /// </summary>
        [JsonPropertyName("class_abilities")]
        public CovenantClassAbility[] ClassAbilities { get; }

        /// <summary>
        /// Gets the soulbind references for this covenant.
        /// </summary>
        [JsonPropertyName("soulbinds")]
        public SoulbindReference[] Soulbinds { get; }

        /// <summary>
        /// Gets the renown rewards for this covenant.
        /// </summary>
        [JsonPropertyName("renown_rewards")]
        public RenownReward[] RenownRewards { get; }

        /// <summary>
        /// Gets the media reference for this covenant.
        /// </summary>
        [JsonPropertyName("media")]
        public CovenantMediaReference Media { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Covenant"/> class.
        /// </summary>
        /// <param name="links">The key for this covenant.</param>
        /// <param name="id">The Id for this covenant.</param>
        /// <param name="name">The name for this covenant.</param>
        /// <param name="description">The description for this covenant.</param>
        /// <param name="signatureAbility">The signature ability for this covenant.</param>
        /// <param name="classAbilities">The various class abilities for this covenant.</param>
        /// <param name="soulbinds">The soulbind references for this covenant.</param>
        /// <param name="renownRewards">The renown rewards for this covenant.</param>
        /// <param name="media">The media reference for this covenant.</param>
        [JsonConstructor]
        public Covenant(Links links, int id, string name, string description, CovenantSignatureAbility signatureAbility, CovenantClassAbility[] classAbilities, SoulbindReference[] soulbinds, RenownReward[] renownRewards, CovenantMediaReference media)
        {
            Links = links;
            Id = id;
            Name = name;
            Description = description;
            SignatureAbility = signatureAbility;
            ClassAbilities = classAbilities;
            Soulbinds = soulbinds;
            RenownRewards = renownRewards;
            Media = media;
        }
    }
}
