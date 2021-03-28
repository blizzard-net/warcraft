using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A covenant soulbind.
    /// </summary>
    public record Soulbind
    {
        /// <summary>
        /// Gets the links for the soulbind.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the Id for this soulbind.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name for this soulbind.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the reference to the covenant this soulbind belongs to.
        /// </summary>
        [JsonPropertyName("covenant")]
        public CovenantReference Covenant { get; }

        /// <summary>
        /// Gets the creature reference for this soulbind.
        /// </summary>
        [JsonPropertyName("creature")]
        public CreatureReference Creature { get; }

        /// <summary>
        /// Gets the follower for this soulbind.
        /// </summary>
        [JsonPropertyName("follower")]
        public SoulbindFollower Follower { get; }

        /// <summary>
        /// Gets the reference to the tech talent tree for this soulbind.
        /// </summary>
        [JsonPropertyName("talent_tree")]
        public TechTalentTreeReference TalentTree { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Soulbind"/> class.
        /// </summary>
        /// <param name="links">The links for the soulbind.</param>
        /// <param name="id">The Id for this soulbind.</param>
        /// <param name="name">The name for this soulbind.</param>
        /// <param name="covenant">The reference to the covenant this soulbind belongs to.</param>
        /// <param name="creature">The creature reference for this soulbind.</param>
        /// <param name="follower">The follower for this soulbind.</param>
        /// <param name="talentTree">The reference to the tech talent tree for this soulbind.</param>
        [JsonConstructor]
        public Soulbind(Links links, int id, string name, CovenantReference covenant, CreatureReference creature, SoulbindFollower follower, TechTalentTreeReference talentTree)
        {
            Links = links;
            Id = id;
            Name = name;
            Covenant = covenant;
            Creature = creature;
            Follower = follower;
            TalentTree = talentTree;
        }
    }
}
