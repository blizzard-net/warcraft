using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A covenant soulbind.
    /// </summary>
    public class Soulbind
    {
        /// <summary>
        /// Gets the links for the soulbind.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the Id for this soulbind.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets the name for this soulbind.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the reference to the covenant this soulbind belongs to.
        /// </summary>
        [JsonPropertyName("covenant")]
        public CovenantReference Covenant { get; set; }

        /// <summary>
        /// Gets the creature reference for this soulbind.
        /// </summary>
        [JsonPropertyName("creature")]
        public CreatureReference Creature { get; set; }

        /// <summary>
        /// Gets the follower for this soulbind.
        /// </summary>
        [JsonPropertyName("follower")]
        public SoulbindFollower Follower { get; set; }

        /// <summary>
        /// Gets the reference to the tech talent tree for this soulbind.
        /// </summary>
        [JsonPropertyName("talent_tree")]
        public TechTalentTreeReference TalentTree { get; set; }
    }
}
