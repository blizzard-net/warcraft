using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Character traits associated with a soulbind.
    /// </summary>
    public record SoulbindTrait
    {
        /// <summary>
        /// Gets a reference to a tech talent selected as a trait for this character.
        /// </summary>
        [JsonPropertyName("trait")]
        public TechTalentReference Trait { get; }

        /// <summary>
        /// Gets the tier for this trait.
        /// </summary>
        [JsonPropertyName("tier")]
        public long Tier { get; }

        /// <summary>
        /// Gets the display order of this trait.
        /// </summary>
        [JsonPropertyName("display_order")]
        public long DisplayOrder { get; }

        /// <summary>
        /// Gets a conduit socket for this character.
        /// </summary>
        [JsonPropertyName("conduit_socket")]
        public ConduitSocketTrait ConduitSocket { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SoulbindTrait"/> class.
        /// </summary>
        /// <param name="trait">A reference to a tech talent selected as a trait for this character.</param>
        /// <param name="tier">The tier for this trait.</param>
        /// <param name="displayOrder">The display order of this trait.</param>
        /// <param name="conduitSocket">A conduit socket for this character.</param>
        [JsonConstructor]
        public SoulbindTrait(TechTalentReference trait, long tier, long displayOrder, ConduitSocketTrait conduitSocket)
        {
            Trait = trait;
            Tier = tier;
            DisplayOrder = displayOrder;
            ConduitSocket = conduitSocket;
        }
    }
}
